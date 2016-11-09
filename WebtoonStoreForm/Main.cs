using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebtoonStoreForm.Interface;

namespace WebtoonStoreForm
{
	public partial class Main : Form
	{
		private bool targetLockon = false;
		private WebtoonBasicInformation? targetBackup;
		private Point startPoint;


		public Main( )
		{
			InitializeComponent( );
		}

		private void Main_Load( object sender, EventArgs e )
		{
			new CopyrightAgree( ).ShowDialog( );

			if ( !GlobalVar.copyrightAgree )
			{
				Application.Exit( );
				return;
			}

			Webtoon.MessageChanged += Webtoon_MessageChanged;
			Webtoon.RequestStatusChanged += Webtoon_RequestStatusChanged;
			Webtoon.ErrorMessageCall += Webtoon_ErrorMessageCall;
			Webtoon.DownloadTargetChanged += Webtoon_DownloadTargetChanged;
			Webtoon.DownloadProgressChanged += Webtoon_DownloadProgressChanged;

			InitializeDownloadStatus( );
		}

		private void MINIMIZE_BUTTON_Click( object sender, EventArgs e )
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			this.Close( );
		}

		private void APP_TITLE_PANEL_MouseMove( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				Rectangle ang = Screen.FromHandle( this.Handle ).WorkingArea;
				this.Location = new Point(
					this.Left - ( startPoint.X - e.X ),
					Math.Max( this.Top - ( startPoint.Y - e.Y ), ang.Top )
				);
			}
		}

		private void APP_TITLE_PANEL_MouseDown( object sender, MouseEventArgs e )
		{
			startPoint = e.Location;
		}

		private void Webtoon_ErrorMessageCall( string message )
		{
			MessageBox.Show( this, message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error );
		}

		private void Webtoon_MessageChanged( string message )
		{
			this.StatusMessageLabel.Text = message;
		}

		private void Webtoon_RequestStatusChanged( bool status )
		{
			CheckForIllegalCrossThreadCalls = false;

			this.REQUEST_BUTTON.Enabled = !status;

			if ( !status )
			{
				InitializeDownloadStatus( );

				MessageBox.Show( this, "다운로드를 완료했습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information );

				System.Diagnostics.Process.Start( "explorer.exe", Webtoon.BaseDirectory );

				Webtoon.BaseDirectory = "";
			}
		}

		private void Webtoon_DownloadProgressChanged( float percent )
		{
			downloadProgress.Value = ( int ) ( percent * 100 );
		}

		private void Webtoon_DownloadTargetChanged( WebtoonPageInformation info )
		{
			//webtoonTitleLabel.Text = info.title;
			starImage.Visible = true;
			webtoonStarRateLabel.Visible = true;

			uploadDateImage.Visible = true;
			webtoonUploadDateLabel.Visible = true;
			//webtoonUploadDateLabel.Text = DateTime.Now.ToString( "yyyy-MM-dd" );

			webtoonDescriptionLabel.Text = info.title;
			webtoonStarRateLabel.Text = info.starRate;
			webtoonUploadDateLabel.Text = info.uploadDate;

			thumbnailImage.Location = new Point( 16, 86 );
			thumbnailImage.Size = new Size( 202, 120 );
			try
			{
				thumbnailImage.Load( info.thumbnailURL );
			}
			catch ( Exception )
			{
				thumbnailImage.Image = null;
			}
		}

		private void InitializeDownloadStatus( )
		{
			REQUEST_BUTTON.Text = "다운로드";

			webtoonTitleLabel.Text = "웹툰 다운로더";
			webtoonDescriptionLabel.Text = "다운받으실 웹툰의 URL을 입력하세요.";

			thumbnailImage.Location = new Point( 7, 45 );
			thumbnailImage.Size = new Size( 220, 202 );
			thumbnailImage.Image = null;

			targetLockon = false;
			targetBackup = null;

			URL_TEXTBOX.Visible = true;
			URL_TEXTBOX.Text = "";
			URL_TEXTBOX_TITLELABEL.Visible = true;
			StatusMessageLabel.Visible = false;
			StatusMessageLabel.Text = "";
			downloadProgress.Visible = false;
			CANCEL_BUTTON.Visible = false;

			downloadProgress.Value = 0;

			starImage.Visible = false;
			webtoonStarRateLabel.Visible = false;
			webtoonStarRateLabel.Text = "0.00";

			uploadDateImage.Visible = false;
			webtoonUploadDateLabel.Visible = false;
			webtoonUploadDateLabel.Text = DateTime.Now.ToString( "yyyy-MM-dd" );
		}

		private async void REQUEST_BUTTON_Click( object sender, EventArgs e )
		{
			if ( targetLockon )
			{
				FolderBrowserDialog dialog = new FolderBrowserDialog( )
				{
					ShowNewFolderButton = true,
					Description = "웹툰이 저장될 폴더를 선택해주세요."
				};

				if ( dialog.ShowDialog( ) == DialogResult.OK )
				{
					if ( targetBackup.HasValue )
					{
						REQUEST_BUTTON.Text = "다운로드 중 ...";

						Webtoon.BaseDirectory = dialog.SelectedPath;

						if ( Webtoon.DownloadThread != null )
						{
							Webtoon.DownloadThread.Abort( );
							Webtoon.DownloadThread = null;
						}

						Webtoon.Request( targetBackup.Value.url );
					}
					else
					{
						InitializeDownloadStatus( );
						MessageBox.Show( this, "알 수 없는 오류가 발생했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error );
					}
				}
				else
				{
					InitializeDownloadStatus( );
					MessageBox.Show( this, "작업이 취소되었습니다.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information );
				}

				return;
			}

			REQUEST_BUTTON.Text = "요청 중 ...";

			WebtoonBasicInformation result = await Webtoon.GetBasicInformation( URL_TEXTBOX.Text.Trim( ) );

			if ( !string.IsNullOrEmpty( result.description ) && !string.IsNullOrEmpty( result.title ) && !string.IsNullOrEmpty( result.thumbnailURL ) )
			{
				targetBackup = result;

				webtoonTitleLabel.Text = result.title;
				webtoonDescriptionLabel.Text = result.description;

				try
				{
					thumbnailImage.Load( result.thumbnailURL );
				}
				catch ( Exception ) { }

				URL_TEXTBOX.Visible = false;
				URL_TEXTBOX_TITLELABEL.Visible = false;
				StatusMessageLabel.Visible = true;
				downloadProgress.Visible = true;
				CANCEL_BUTTON.Visible = true;

				targetLockon = true;

				REQUEST_BUTTON.Text = "웹툰 전체 다운로드!";

				return;
			}
			else
			{
				targetLockon = false;
			}

			REQUEST_BUTTON.Text = "다운로드";
		}

		private void APP_LOGO_Click( object sender, EventArgs e )
		{

		}

		private void CANCEL_BUTTON_Click( object sender, EventArgs e )
		{
			if ( targetLockon )
			{
				if ( Webtoon.DownloadThread != null )
				{
					DialogResult result = MessageBox.Show( this, "다운로드를 취소하시겠습니까?", "질문", MessageBoxButtons.YesNo, MessageBoxIcon.Question );

					if ( result == DialogResult.No ) return;

					Webtoon.DownloadThread.Abort( );
					Webtoon.DownloadThread = null;
				}

				InitializeDownloadStatus( );
				MessageBox.Show( this, "작업이 취소되었습니다.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information );

				REQUEST_BUTTON.Enabled = true;
			}
		}

		private void webtoonUploadDateLabel_Click( object sender, EventArgs e )
		{

		}

		private void uploadDateImage_Click( object sender, EventArgs e )
		{

		}
	}
}
