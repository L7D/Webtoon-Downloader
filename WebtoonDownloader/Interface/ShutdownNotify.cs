using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebtoonDownloader.Interface
{
	public partial class ShutdownNotify : Form
	{
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.outlineColor )
		{
			Width = 1
		};

		public ShutdownNotify( )
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

		private void ShutdownNotify_Load( object sender, EventArgs e )
		{
			int tickNum = 60;

			Timer shutdownTickChange = new Timer( )
			{
				Interval = 1000
			};
			shutdownTickChange.Tick += delegate( object sender2, EventArgs e2 )
			{
				tickNum--;

				systemShutdownCount.Text = tickNum + "초 후 시스템이 종료됩니다.";

				if ( tickNum <= 0 )
				{
					shutdownTickChange.Stop( );
					shutdownTickChange.Dispose( );
					this.Close( );
				}
			};
			shutdownTickChange.Start( );
		}

		private void CANCEL_SYSTEM_SHUTDOWN_Click( object sender, EventArgs e )
		{
			System.Diagnostics.Process.Start( "shutdown", "/a" ); // 시스템 종료 취소

			this.Close( );
		}

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			this.Close( );
		}

		private void APP_TITLE_BAR_Paint( object sender, PaintEventArgs e )
		{
			int w = this.APP_TITLE_BAR.Width, h = this.APP_TITLE_BAR.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // Top line drawing
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // Left line drawing
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // Right line drawing
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
		}

		private void ShutdownNotify_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // Top line drawing
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // Left line drawing
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // Right line drawing
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
		}
	}
}
