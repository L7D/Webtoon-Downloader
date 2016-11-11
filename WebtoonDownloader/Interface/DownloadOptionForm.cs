using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebtoonDownloader.API;

namespace WebtoonDownloader.Interface
{
	public partial class DownloadOptionForm : Form
	{
		private Thread loadThread;
		private List<WebtoonListChild> temp = new List<WebtoonListChild>( );
		public event Action<DownloadOptionResult, object> DownloadOptionReturn;
		private bool isASCSortMode = true;
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.outlineColor )
		{
			Width = 1
		};
		public WebtoonBasicInformation baseInformation
		{
			get;
			set;
		}

		public DownloadOptionForm( )
		{
			InitializeComponent( );
		}

		private void APP_TITLE_BAR_MouseMove( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				this.Location = new Point(
					this.Left - ( startPoint.X - e.X ),
					Math.Max( this.Top - ( startPoint.Y - e.Y ), Screen.FromHandle( this.Handle ).WorkingArea.Top )
				);
			}
		}

		private void APP_TITLE_BAR_MouseDown( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				startPoint = e.Location;
			}
		}

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			NotifyBoxResult result = NotifyBox.Show( this, "질문", "다운로드를 취소하시겠습니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Question );

			if ( result == NotifyBoxResult.Yes )
			{
				DownloadOptionReturn.Invoke( DownloadOptionResult.Cancel, null );
			}
		}

		private void APP_TITLE_BAR_Paint( object sender, PaintEventArgs e )
		{
			int w = this.APP_TITLE_BAR.Width, h = this.APP_TITLE_BAR.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // Top line drawing
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // Left line drawing
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // Right line drawing
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
		}

		private void DownloadOptionForm_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // Top line drawing
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // Left line drawing
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // Right line drawing
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
		}

		private void StartLoadingMode( )
		{
			this.sortSwitchImageButton.Enabled = false;
			this.DOWNLOAD_BUTTON.Enabled = false;
			this.loadingStatusLabel.Visible = true;

			this.searchTextBox.Enabled = false;
			//this.webtoonPageList.Enabled = false;
		}

		private void StopLoadingMode( )
		{
			this.sortSwitchImageButton.Enabled = true;
			this.DOWNLOAD_BUTTON.Enabled = true;
			this.loadingStatusLabel.Visible = false;

			this.searchTextBox.Enabled = true;
			//this.webtoonPageList.Enabled = true;
		}

		private void PageSearch( string searchText )
		{
			int newY = 0;

			webtoonPageList.VerticalScroll.Value = webtoonPageList.VerticalScroll.Minimum; // 현재 스크롤을 Minimum 값으로 변경

			if ( searchText == "" )
			{

				for ( int i = 0; i < webtoonPageList.Controls.Count; i++ )
				{
					WebtoonListChild webtoonListChild = ( WebtoonListChild ) webtoonPageList.Controls[ i ];

					webtoonListChild.Location = new Point( 0, newY );
					webtoonListChild.Visible = true;

					newY += 90 + 5;
				}

				temp.Clear( );

				return;
			}

			for ( int i = 0; i < webtoonPageList.Controls.Count; i++ )
			{
				WebtoonListChild webtoonListChild = ( WebtoonListChild ) webtoonPageList.Controls[ i ];

				// 다운로드 차단된 화 이면 건너뜀
				if ( webtoonListChild.blocked )
				{
					webtoonListChild.Visible = false;
					continue;
				}

				// temp 에 해당 컨트롤이 포함되어 있으면
				if ( temp.Contains( webtoonListChild ) )
				{
					// 그것은 이전에 검색에 포함되어 Y 위치가 변경된 컨트롤이니 이전의 위치로 변경. (초기화)
					webtoonPageList.Controls[ i ].Location = new Point( 0, webtoonListChild.Location.Y );

					// temp 에서 지우기
					temp.Remove( webtoonListChild );
				}

				// 검색어가 화 제목(info.title)에 포함되어있는지 검색
				if ( webtoonListChild.info.title.Contains( searchText ) )
				{
					//	webtoonPageList.ScrollControlIntoView( webtoonListChild );

					// 이전의 위치를 알아내기 위해 temp 에 백업
					temp.Add( webtoonListChild );

					// Y 위치를 재설정
					webtoonListChild.Location = new Point( 0, newY );
					webtoonListChild.Visible = true;

					webtoonListChild.Highlight( );

					newY += 90 + 5;
				}
				else
				{
					webtoonListChild.Visible = false;
				}
			}
		}

		private void DownloadOptionForm_Load( object sender, EventArgs e )
		{
			webtoonTitleLabel.Text = baseInformation.title;
			webtoonDescriptionLabel.Text = baseInformation.description;
			webtoonNumLabel.Text = "총 " + baseInformation.totalNum + "개의 화";
			try
			{
				webtoonThumbnailImage.Load( baseInformation.thumbnailURL );
			}
			catch ( Exception )
			{
				webtoonThumbnailImage.Image = null;
			}

			DOWNLOAD_BUTTON.Enabled = false;

			isASCSortMode = true;
			toolTipControl.SetToolTip( sortSwitchImageButton, "오래된 화 순으로 정렬합니다." );

			StartLoadingMode( );

			loadThread = new Thread( ( ) =>
			{
				int count = 0;
				int y = 0;

				foreach ( WebtoonPageInformation info in baseInformation.pages )
				{
					count++;

					WebtoonListChild child = new WebtoonListChild( info );
					child.Location = new Point( 0, y );

					if ( this.InvokeRequired )
					{
						this.Invoke( new Action( ( ) =>
						{
							webtoonPageList.Controls.Add( child );
							loadingStatusLabel.Text = "데이터를 불러오고 있습니다 ... " + ( int ) ( ( ( float ) count / ( float ) baseInformation.pages.Count ) * 100 ) + "%";
						} ) );
					}
					else
					{
						webtoonPageList.Controls.Add( child );
						loadingStatusLabel.Text = "데이터를 불러오고 있습니다 ... " + ( int ) ( ( ( float ) count / ( float ) baseInformation.pages.Count ) * 100 ) + "%";
					}

					y += child.Size.Height + 5;
				}

				Thread.Sleep( 1000 );

				if ( this.InvokeRequired )
					this.Invoke( new Action( ( ) => StopLoadingMode( ) ) );
				else
					StopLoadingMode( );
			} )
			{
				IsBackground = true
			};

			loadThread.Start( );
		}

		private void searchTextBox_TextChanged( object sender, EventArgs e )
		{
			PageSearch( searchTextBox.Text );
		}

		private void sortSwitchImageButton_Click( object sender, EventArgs e )
		{
			isASCSortMode = !isASCSortMode;

			webtoonPageList.SuspendLayout( );

			webtoonPageList.VerticalScroll.Value = webtoonPageList.VerticalScroll.Minimum; // 현재 스크롤을 Minimum 값으로 변경

			if ( !isASCSortMode )
			{
				int y = 0;

				// 정렬을 하기 위해서 현재 컨트롤 컬렉션을 복사하고
				Control[ ] newControl = new Control[ webtoonPageList.Controls.Count ];

				webtoonPageList.Controls.CopyTo( newControl, 0 );

				// 배열을 뒤집는다 (오름차 <-> 내림차)
				Array.Reverse( newControl );

				// Y 포지션 위치 재설정
				for ( int i = 0; i < newControl.Length; i++ )
				{
					newControl[ i ].Location = new Point( 0, y );

					y += 90 + 5;
				}

				// 바뀐 배열을 다시 컨트롤 컬렉션에 넣는다
				webtoonPageList.Controls.Clear( );
				webtoonPageList.Controls.AddRange( newControl );

				sortSwitchImageButton.Image = Properties.Resources.descSort;
			}
			else
			{
				int y = 0;

				// 정렬을 하기 위해서 현재 컨트롤 컬렉션을 복사하고
				Control[ ] newControl = new Control[ webtoonPageList.Controls.Count ];

				webtoonPageList.Controls.CopyTo( newControl, 0 );

				// 배열을 뒤집는다 (오름차 <-> 내림차)
				Array.Reverse( newControl );

				// Y 포지션 위치 재설정
				for ( int i = 0; i < newControl.Length; i++ )
				{
					newControl[ i ].Location = new Point( 0, y );

					y += 90 + 5;
				}

				// 바뀐 배열을 다시 컨트롤 컬렉션에 넣는다
				webtoonPageList.Controls.Clear( );
				webtoonPageList.Controls.AddRange( newControl );

				sortSwitchImageButton.Image = Properties.Resources.ascSort;
			}

			webtoonPageList.AutoScroll = false;
			webtoonPageList.AutoScroll = true;
			webtoonPageList.ResumeLayout( false );
			webtoonPageList.PerformLayout( );

			toolTipControl.SetToolTip( sortSwitchImageButton, ( isASCSortMode ? "오래된" : "최근" ) + " 화 순으로 정렬합니다." );
		}

		private void DOWNLOAD_BUTTON_Click( object sender, EventArgs e )
		{
			Webtoon.DownloadBlockList.Clear( );

			int count = 0;
			for ( int i = 0; i < webtoonPageList.Controls.Count; i++ )
			{
				WebtoonListChild webtoonListChild = ( WebtoonListChild ) webtoonPageList.Controls[ i ];

				if ( webtoonListChild.blocked )
				{
					Webtoon.DownloadBlockList.Add( webtoonListChild.info.num );
					count++;
				}
			}

			if ( count >= baseInformation.pages.Count )
			{
				NotifyBox.Show( this, "오류", "최소 1개의 화는 다운받아야 합니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
				return;
			}

			FolderBrowserDialog dialog = new FolderBrowserDialog( )
			{
				ShowNewFolderButton = true,
				Description = "해당 웹툰을 어디에 저장하시겠습니까?"
			};

			if ( dialog.ShowDialog( ) == DialogResult.OK )
			{
				Webtoon.BaseDirectory = dialog.SelectedPath;
				DownloadOptionReturn.Invoke( DownloadOptionResult.DownloadClick, null );
			}
		}

		private void fastDownloadModeSwitch_Click( object sender, EventArgs e )
		{
			Webtoon.FastDownloadMode = !Webtoon.FastDownloadMode;

			if ( Webtoon.FastDownloadMode )
			{
				fastDownloadModeTitle.Text = "고속 다운로드 모드 활성화 됨";
				fastDownloadModeSwitch.EnterStateBackgroundColor = Color.DimGray;
				fastDownloadModeSwitch.NormalStateBackgroundColor = Color.MediumAquamarine;
			}
			else
			{
				fastDownloadModeTitle.Text = "고속 다운로드 모드 비 활성화 됨";
				fastDownloadModeSwitch.EnterStateBackgroundColor = Color.MediumAquamarine;
				fastDownloadModeSwitch.NormalStateBackgroundColor = Color.DimGray;
			}
		}

		private void DownloadOptionForm_FormClosed( object sender, FormClosedEventArgs e )
		{
			loadThread.Abort( );
		}
	}
}
