using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebtoonDownloader.API;

namespace WebtoonDownloader.Interface
{
	public partial class Information : Form
	{
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.outlineColor )
		{
			Width = 1
		};

		public Information( )
		{
			InitializeComponent( );
		}

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
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

		private void APP_TITLE_BAR_Paint( object sender, PaintEventArgs e )
		{
			int w = this.APP_TITLE_BAR.Width, h = this.APP_TITLE_BAR.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // Top line drawing
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // Left line drawing
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // Right line drawing
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
		}

		private void Information_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // Top line drawing
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // Left line drawing
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // Right line drawing
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
		}

		private void Information_Load( object sender, EventArgs e )
		{
			Version version = System.Reflection.Assembly.GetExecutingAssembly( ).GetName( ).Version;

			programVersion.Text = "버전 " + version.Major + "." + version.Minor + "." + version.Build + "." + version.Revision;
		}

		private void openSourceProjectButton_Click( object sender, EventArgs e )
		{
			try
			{
				System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo( "en-US" );

				System.Diagnostics.Process.Start( "https://github.com/DeveloFOX-Studio/Webtoon-Downloader" );
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, "Exception" );
				NotifyBox.Show( this, "오류", "알 수 없는 오류가 발생했습니다, 로그 파일을 참고하세요.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
		}
	}
}
