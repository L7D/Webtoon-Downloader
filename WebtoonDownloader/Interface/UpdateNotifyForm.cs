using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebtoonDownloader.API;

namespace WebtoonDownloader.Interface
{
	public partial class UpdateNotifyForm : Form
	{
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.outlineColor )
		{
			Width = 1
		};

		public UpdateNotifyForm( )
		{
			InitializeComponent( );
		}

		private void UpdateNotifyForm_Load( object sender, EventArgs e )
		{
			try
			{
				WebClient client = new WebClient( );
				string htmlString = client.DownloadString( "https://raw.githubusercontent.com/DeveloFOX-Studio/Webtoon-Downloader/master/Update/updateLog.html" );

				updateLogHTMLText.DocumentText = "0";
				updateLogHTMLText.Document.OpenNew( true );
				updateLogHTMLText.Document.Write( htmlString );
				updateLogHTMLText.Refresh( );
			}
			catch ( WebException ex )
			{
				NotifyBox.Show( this, "오류", "업데이트 내역을 가져올 수 없습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
			catch ( Exception ex )
			{
				NotifyBox.Show( this, "오류", "업데이트 내역을 가져올 수 없습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
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

		private void UpdateNotifyForm_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // Top line drawing
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // Left line drawing
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // Right line drawing
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
		}

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			this.Close( );
		}

		private void UPDATE_BUTTON_Click( object sender, EventArgs e )
		{

		}
	}
}
