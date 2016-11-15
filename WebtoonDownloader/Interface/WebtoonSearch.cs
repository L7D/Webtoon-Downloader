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
	public partial class WebtoonSearch : Form
	{
		private System.Windows.Forms.Timer dotAnimationTimer;
		private bool UIMode_private;
		private bool UIMode
		{
			set
			{
				UIMode_private = value;

				if ( value )
				{
					searchMasterPanel.Visible = false;
					searchResultPanel.Visible = true;

					this.Size = new Size( 800, 675 );
				}
				else
				{
					webtoonSearchResultList.Controls.Clear( );

					searchTextBox.Text = "";
					webtoonDirectURLTextBox.Text = "";

					searchMasterPanel.Visible = true;
					searchResultPanel.Visible = false;

					this.Size = new Size( 800, 358 );
				}
			}
			get
			{
				return UIMode_private;
			}
		}
		private int dotCount = 0;
		private Thread loadThread;
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.outlineColor )
		{
			Width = 1
		};

		public WebtoonSearch( )
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

		private void APP_TITLE_BAR_Paint( object sender, PaintEventArgs e )
		{
			int w = this.APP_TITLE_BAR.Width, h = this.APP_TITLE_BAR.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // Top line drawing
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // Left line drawing
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // Right line drawing
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
		}

		private void StartLoadingMode( string searchText = null )
		{
			this.webtoonSearchResultList.Enabled = false;
			this.researchButton.ButtonText = "검색 취소";

			if ( searchText != null )
			{
				this.searchStatusLabel.Text = "'" + searchText + "'(이)가 포함된 웹툰을 검색 중 입니다 ";
				StartDotAnimation( );
			}
			else
			{

			}
		}

		private void StartDotAnimation( )
		{
			if ( dotAnimationTimer != null && !dotAnimationTimer.Enabled )
			{
				dotAnimationTimer.Start( );

				dotCount = 0;
			}
		}

		private void StopDotAnimation( )
		{
			if ( dotAnimationTimer != null && dotAnimationTimer.Enabled )
			{
				dotAnimationTimer.Stop( );

				dotCount = 0;
			}
		}

		private void StopLoadingMode( string searchText = null, int resultCount = 0 )
		{
			StopDotAnimation( );

			this.webtoonSearchResultList.Enabled = true;
			this.researchButton.ButtonText = "다시 검색";

			if ( searchText != null )
				this.searchStatusLabel.Text = resultCount > 0 ? "'" + searchText + "'에 대한 " + resultCount + "개의 검색 결과가 있습니다." : "'" + searchText + "'에 대한 검색 결과가 없습니다.";
		}

		private void Webtoon_Selected( WebtoonSearchResult info )
		{
			( ( Main ) this.Owner ).DownloadBegin( info.url );
			this.Close( );
		}

		private void WebtoonSearch_Load( object sender, EventArgs e )
		{
			searchTextBox.Focus( );

			UIMode = false;

			dotAnimationTimer = new System.Windows.Forms.Timer( )
			{
				Interval = 100
			};
			dotAnimationTimer.Tick += delegate ( object sender2, EventArgs e2 )
			{
				if ( dotCount > 2 )
				{
					dotCount = 0;
					this.searchStatusLabel.Text = this.searchStatusLabel.Text.Substring( 0, this.searchStatusLabel.Text.Length - 3 );
					return;
				}

				this.searchStatusLabel.Text = this.searchStatusLabel.Text + ".";
				dotCount++;
			};
		}

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			this.Close( );
		}

		private void WebtoonSearch_FormClosed( object sender, FormClosedEventArgs e )
		{
			if ( loadThread != null )
				loadThread.Abort( );
		}

		private void searchTextBox_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Enter )
			{
				searchButton_Click( null, EventArgs.Empty );
				e.Handled = true;
			}
		}

		private void webtoonDirectURLTextBox_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Enter )
			{
				searchURLButton_Click( null, EventArgs.Empty );
				e.Handled = true;
			}
		}

		private void searchButton_Click( object sender, EventArgs e )
		{
			string searchText = searchTextBox.Text.Trim( );
			string searchURL = webtoonDirectURLTextBox.Text.Trim( );

			if ( searchText.Length <= 0 && searchURL.Length <= 0 )
			{
				NotifyBox.Show( this, "안내", "검색할 웹툰의 이름을 입력하시거나, 해당 웹툰의 주소를 입력하세요.", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				return;
			}

			if ( searchURL.Length > 0 )
			{
				if ( Webtoon.IsValidFixURL( ref searchURL ) )
				{
					( ( Main ) this.Owner ).DownloadBegin( searchURL );
					this.Close( );
				}
				else
				{
					NotifyBox.Show( this, "오류", "입력한 웹툰 링크가 올바르지 않습니다, 올바른 링크를 입력하세요.", NotifyBoxType.OK, NotifyBoxIcon.Error );

					webtoonDirectURLTextBox.Text = "";
					webtoonDirectURLTextBox.Focus( );
				}

				return;
			}

			UIMode = true;
			StartLoadingMode( searchText );

			if ( loadThread != null )
			{
				loadThread.Abort( );
				loadThread = null;
			}

			webtoonSearchResultList.Controls.Clear( );

			loadThread = new Thread( ( ) =>
			{
				try
				{
					int count = 0;
					int y = 0;

					List<WebtoonSearchResult> searchResult = Webtoon.SearchTitle( searchText );

					StopDotAnimation( );

					foreach ( WebtoonSearchResult info in searchResult )
					{
						count++;

						WebtoonSearchListChild child = new WebtoonSearchListChild( info );
						child.Location = new Point( 0, y );
						child.Selected += Webtoon_Selected;

						if ( this.InvokeRequired )
						{
							this.Invoke( new Action( ( ) =>
							{
								webtoonSearchResultList.Controls.Add( child );
								searchStatusLabel.Text = "검색 결과를 정리하고 있습니다 ... " + ( int ) ( ( ( float ) count / ( float ) searchResult.Count ) * 100 ) + "%";
							} ) );
						}
						else
						{
							webtoonSearchResultList.Controls.Add( child );
							searchStatusLabel.Text = "검색 결과를 정리하고 있습니다 ... " + ( int ) ( ( ( float ) count / ( float ) searchResult.Count ) * 100 ) + "%";
						}

						y += child.Size.Height + 5;
					}

					Thread.Sleep( 1000 );

					if ( this.InvokeRequired )
						this.Invoke( new Action( ( ) => StopLoadingMode( searchText, searchResult.Count ) ) );
					else
						StopLoadingMode( searchText, searchResult.Count );
				}
				catch ( ThreadAbortException )
				{
					GC.Collect( 0, GCCollectionMode.Forced ); // 쓰레드가 강제 종료된 후 메모리를 정리하기 위해 GC 강제 실행
				}
			} )
			{
				IsBackground = true
			};

			loadThread.Start( );
		}


		private void searchURLButton_Click( object sender, EventArgs e )
		{
			string url = webtoonDirectURLTextBox.Text.Trim( );

			if ( url.Length <= 0 )
			{
				NotifyBox.Show( this, "안내", "링크를 입력하세요.", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				return;
			}

			//( ( Main ) this.Owner ).Download( url );

			

			//Thread requestThread = new Thread( async ( ) =>
			//{
			//	WebtoonBasicInformation result = await Webtoon.GetBasicInformation( url );

			//	if ( !string.IsNullOrEmpty( result.title ) && !string.IsNullOrEmpty( result.description ) && !string.IsNullOrEmpty( result.thumbnailURL ) ) // 추가 필요
			//	{

			//	}
			//	else
			//	{
			//		NotifyBox.Show( this, "오류", "해당 웹툰의 데이터를 불러올 수 없습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			//	}
			//} )
			//{
			//	IsBackground = true
			//};

			//requestThread.Start( );
		}

		private void researchButton_Click( object sender, EventArgs e )
		{
			// 13, 46
			if ( UIMode )
			{
				if ( loadThread != null )
				{
					loadThread.Abort( );
					loadThread = null;
				}

				UIMode = false;
				StopLoadingMode( );
			}
		}

		private void WebtoonSearch_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // Top line drawing
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // Left line drawing
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // Right line drawing
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
		}

	}
}
