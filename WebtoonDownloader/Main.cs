using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using WebtoonDownloader.API;
using WebtoonDownloader.Interface;

namespace WebtoonDownloader
{
	public enum DownloadOptionResult
	{
		Cancel,
		DownloadClick
	}

	public partial class Main : Form
	{
		public enum UIStatus
		{
			Idle,
			BaseInformationRequesting,
			BaseInformationTargetLockOned,
			Working
		}
		private WebtoonBasicInformation? targetWebtoonBasicInformation;
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.outlineColor )
		{
			Width = 1
		};
		private UIStatus UIStatusVar_private;
		public UIStatus UIStatusVar
		{
			set
			{
				UIStatusVar_private = value;

				switch ( value )
				{
					case UIStatus.Idle:
						Webtoon.FastDownloadMode = false;
						Webtoon.DownloadBlockList.Clear( );
						Webtoon.BaseDirectory = "";

						REQUEST_BUTTON.ButtonText = "다운로드";
						REQUEST_BUTTON.Enabled = true;
						REQUEST_BUTTON.Visible = false;

						searchButton.Visible = true;

						webtoonTitleLabel.Text = "웹툰 다운로더";
						webtoonDescriptionLabel.Text = "다운로드 받으실 웹툰을 찾아보세요.";

						webtoonTitleLabel.Location = new Point( 9, 120 );
						webtoonTitleLabel.Size = new Size( 583, 30 );

						webtoonDescriptionLabel.Location = new Point( 9, 155 );
						webtoonDescriptionLabel.Size = new Size( 583, 60 );

						thumbnailImage.Visible = false;
						thumbnailImage.Location = new Point( 7, 60 );
						thumbnailImage.Size = new Size( 220, 202 );
						thumbnailImage.Image = null;

						downFinishShutDownCheckBox.Visible = false;
						downFinishShutDownCheckBox.Checked = false;

						//backgroundImage.Image = Properties.Resources.background;
						SetRandomBackgroundWallpaper( );

						targetWebtoonBasicInformation = null;

						downloadProgress.Visible = false;
						CANCEL_BUTTON.Visible = false;

						downloadProgress.Progress = 1;

						starImage.Visible = false;
						webtoonStarRateLabel.Visible = false;
						webtoonStarRateLabel.Text = "0.00";

						uploadDateImage.Visible = false;
						webtoonUploadDateLabel.Visible = false;
						webtoonUploadDateLabel.Text = DateTime.Now.ToString( "yyyy-MM-dd" );

						break;
					case UIStatus.BaseInformationRequesting:
						REQUEST_BUTTON.Enabled = true;
						REQUEST_BUTTON.Visible = false;
						searchButton.Visible = false;
						break;
					case UIStatus.BaseInformationTargetLockOned:
						WebtoonBasicInformation target = ( WebtoonBasicInformation ) targetWebtoonBasicInformation;

						REQUEST_BUTTON.ButtonText = "다운로드!";
						REQUEST_BUTTON.Enabled = true;
						REQUEST_BUTTON.Visible = true;

						searchButton.Visible = false;

						webtoonTitleLabel.Text = target.title;
						webtoonDescriptionLabel.Text = target.description;

						downloadProgress.Visible = true;
						CANCEL_BUTTON.Visible = true;

						break;
					case UIStatus.Working:
						downFinishShutDownCheckBox.Visible = true;
						downFinishShutDownCheckBox.Checked = false;
						REQUEST_BUTTON.ButtonText = "다운로드 중 ...";
						REQUEST_BUTTON.Enabled = false;
						REQUEST_BUTTON.Visible = true;
						searchButton.Visible = false;
						break;
				}
			}
			get
			{
				return UIStatusVar_private;
			}
		}

		public Main( )
		{
			InitializeComponent( );
		}

		private void SetRandomBackgroundWallpaper( )
		{
			string dir = Application.StartupPath + @"\theme";

			if ( System.IO.Directory.Exists( dir ) )
			{
				string[ ] files = System.IO.Directory.GetFiles( Application.StartupPath + @"\theme\", "background_*.png", System.IO.SearchOption.TopDirectoryOnly );

				backgroundImage.Image = Image.FromFile( files[ new Random( ).Next( 0, files.Length ) ] );
			}
			else
			{
				backgroundImage.Image = null;
			}
		}

		private void Main_Load( object sender, EventArgs e )
		{
			new Welcome( ).ShowDialog( );
			new CopyrightAgree( ).ShowDialog( );

			if ( !GlobalVar.copyrightAgree )
			{
				Application.Exit( );
				return;
			}

			//APP_TITLE_BAR.BackColor = Color.FromArgb( 200, 255, 255, 255 );
			APP_TITLE_BAR.Parent = backgroundImage;

			starImage.Parent = backgroundImage;
			webtoonStarRateLabel.Parent = backgroundImage;

			uploadDateImage.Parent = backgroundImage;
			webtoonUploadDateLabel.Parent = backgroundImage;

			webtoonTitleLabel.Parent = backgroundImage;
			webtoonDescriptionLabel.Parent = backgroundImage;

			webtoonTitleLabel.BackColor = Color.FromArgb( 200, 255, 255, 255 );
			webtoonDescriptionLabel.BackColor = Color.FromArgb( 200, 255, 255, 255 );

			webtoonStarRateLabel.BackColor = Color.FromArgb( 200, 255, 255, 255 );
			webtoonUploadDateLabel.BackColor = Color.FromArgb( 200, 255, 255, 255 );

			Webtoon.StatusMessageLabelSet += Webtoon_StatusMessageLabel_Set;
			Webtoon.DownloadFinished += Webtoon_DownloadFinished;
			Webtoon.ErrorMessageCall += Webtoon_ErrorMessageCall;
			Webtoon.DownloadTargetChanged += Webtoon_DownloadTargetChanged;
			Webtoon.DownloadProgressChanged += Webtoon_DownloadProgressChanged;

			UIStatusVar = UIStatus.Idle;
		}

		private void MINIMIZE_BUTTON_Click( object sender, EventArgs e )
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			if ( UIStatusVar == UIStatus.Working )
			{
				NotifyBoxResult result = NotifyBox.Show( this, "질문", "다운로드가 현재 진행 중 입니다, 취소하고 프로그램을 종료하시겠습니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Question );

				if ( result == NotifyBoxResult.No ) return;

				Webtoon.DownloadThread.Abort( );
				Webtoon.DownloadThread = null;
			}

			this.Close( );
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

		private void Webtoon_ErrorMessageCall( string message )
		{
			CheckForIllegalCrossThreadCalls = false;

			NotifyBox.Show( this, "오류", message, NotifyBoxType.OK, NotifyBoxIcon.Error );
		}

		private void Webtoon_StatusMessageLabel_Set( string message )
		{
			webtoonDescriptionLabel.Text = message;
		}

		private void Webtoon_DownloadFinished( bool success )
		{
			if ( success )
			{
				GC.Collect( 0, GCCollectionMode.Forced ); // 쓰레드가 강제 종료된 후 메모리를 정리하기 위해 GC 강제 실행

				if ( downFinishShutDownCheckBox.Checked )
				{
					UIStatusVar = UIStatus.Idle;
					//System.Diagnostics.Process.Start( "shutdown", "/s /f /t 60" ); // 시스템 종료

					Win32.InitiateSystemShutdown( "\\\\127.0.0.1",  // 컴퓨터 이름
						null,           // 종료 전 사용자에게 알릴 메시지
						60,             // 종료까지 대기 시간
						false,          // 프로그램 강제 종료 여부(false > 강제 종료)
						false           // 시스템 종료 후 다시 시작 여부(true > 다시 시작)
					);

					new ShutdownNotify( ).ShowDialog( );

					return;
				}

				System.Diagnostics.Process.Start( "explorer.exe", Webtoon.BaseDirectory );

				UIStatusVar = UIStatus.Idle;

				NotifyBox.Show( this, "다운로드 완료", "다운로드를 모두 마무리했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Information );
			}
			else
			{
				UIStatusVar = UIStatus.Idle;
			}
		}

		private void Webtoon_DownloadProgressChanged( float percent )
		{
			downloadProgress.Progress = ( int ) ( percent * 100 );
		}

		private void Webtoon_DownloadTargetChanged( WebtoonPageInformation info )
		{
			CheckForIllegalCrossThreadCalls = false;

			starImage.Visible = true;
			webtoonStarRateLabel.Visible = true;

			uploadDateImage.Visible = true;
			webtoonUploadDateLabel.Visible = true;

			webtoonTitleLabel.Text = info.title;
			webtoonStarRateLabel.Text = info.starRate;
			webtoonUploadDateLabel.Text = info.uploadDate;

			webtoonTitleLabel.Location = new Point( 9, 180 );
			webtoonTitleLabel.Size = new Size( 583, 25 );

			webtoonDescriptionLabel.Location = new Point( 9, 210 );
			webtoonDescriptionLabel.Size = new Size( 583, 60 );

			thumbnailImage.Location = new Point( 199, 50 );
			thumbnailImage.Size = new Size( 202, 120 );

			try
			{
				thumbnailImage.Visible = true;
				thumbnailImage.Load( info.thumbnailURL );
			}
			catch ( Exception )
			{
				thumbnailImage.Image = null;
			}
		}

		private void REQUEST_BUTTON_Click( object sender, EventArgs e )
		{
			if ( UIStatusVar == UIStatus.BaseInformationTargetLockOned )
			{
				DownloadOptionForm Form = new DownloadOptionForm( )
				{
					Owner = this
				};
				Form.baseInformation = ( WebtoonBasicInformation ) targetWebtoonBasicInformation;
				Form.DownloadOptionReturn += delegate ( DownloadOptionResult result, object data )
				{
					switch ( result )
					{
						case DownloadOptionResult.DownloadClick:
							Form.Close( );
							UIStatusVar = UIStatus.Working;

							if ( Webtoon.DownloadThread != null )
							{
								Webtoon.DownloadThread.Abort( );
								Webtoon.DownloadThread = null;
							}

							Webtoon.Request( targetWebtoonBasicInformation.Value.url );

							break;
						case DownloadOptionResult.Cancel:
							Form.Close( );
							CANCEL_BUTTON_Click( null, EventArgs.Empty );

							break;
					}
				};
				Form.ShowDialog( );

				return;
			}
		}

		private void APP_LOGO_Click( object sender, EventArgs e )
		{
			Information form = new Information( );
			form.Owner = this;
			form.ShowDialog( );
		}

		private void CANCEL_BUTTON_Click( object sender, EventArgs e )
		{
			if ( UIStatusVar == UIStatus.Working || UIStatusVar == UIStatus.BaseInformationTargetLockOned )
			{
				if ( Webtoon.DownloadThread != null )
				{
					NotifyBoxResult result = NotifyBox.Show( this, "질문", "다운로드를 취소하시겠습니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Question );

					if ( result == NotifyBoxResult.No ) return;

					Webtoon.DownloadThread.Abort( );
					Webtoon.DownloadThread = null;
				}

				UIStatusVar = UIStatus.Idle;

				NotifyBox.Show( this, "안내", "작업이 취소되었습니다", NotifyBoxType.OK, NotifyBoxIcon.Information );
			}
		}

		private void APP_TITLE_BAR_Paint( object sender, PaintEventArgs e )
		{
			//int w = this.APP_TITLE_BAR.Width, h = this.APP_TITLE_BAR.Height;

			//e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // Top line drawing
			//e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // Left line drawing
			//e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // Right line drawing
			//e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
		}

		private void Main_Paint( object sender, PaintEventArgs e )
		{

		}

		private void thumbnailImage_Paint( object sender, PaintEventArgs e )
		{
			int w = this.thumbnailImage.Width, h = this.thumbnailImage.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // Top line drawing
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // Left line drawing
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // Right line drawing
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
		}

		private void backgroundImage_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // Top line drawing
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // Left line drawing
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // Right line drawing
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
		}

		public void DownloadBegin( string url )
		{
			if ( UIStatusVar == UIStatus.Idle )
			{
				UIStatusVar = UIStatus.BaseInformationRequesting;

				Thread requestThread = new Thread( async ( ) =>
				{
					WebtoonBasicInformation result = await Webtoon.GetBasicInformation( url );

					if ( !string.IsNullOrEmpty( result.title ) && !string.IsNullOrEmpty( result.description ) && !string.IsNullOrEmpty( result.thumbnailURL ) ) // 추가 필요
					{
						targetWebtoonBasicInformation = result;

						if ( this.InvokeRequired )
						{
							this.Invoke( new Action( delegate ( )
							{
								UIStatusVar = UIStatus.BaseInformationTargetLockOned;
							} ) );
						}
						else
						{
							UIStatusVar = UIStatus.BaseInformationTargetLockOned;
						}

						return;
					}
					else
					{
						UIStatusVar = UIStatus.Idle;
						NotifyBox.Show( this, "오류", "해당 웹툰의 데이터를 불러올 수 없습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
					}
				} )
				{
					IsBackground = true
				};

				requestThread.Start( );
			}
		}

		private void searchButton_Click( object sender, EventArgs e )
		{
			WebtoonSearch form = new WebtoonSearch( );
			form.Size = new Size( 800, 358 );
			form.Owner = this;
			form.ShowDialog( );
		}
	}
}
