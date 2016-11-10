using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebtoonStoreForm.Interface
{
	public partial class Welcome : Form
	{
		private Pen lineDrawer = new Pen( Color.DarkGray )
		{
			Width = 1
		};

		public Welcome( )
		{
			InitializeComponent( );
		}

		private void Welcome_Load( object sender, EventArgs e )
		{
			System.Threading.Thread closeWait = new System.Threading.Thread( ( ) =>
			{
				System.Threading.Thread.Sleep( 2000 );

				if ( this.InvokeRequired )
				{
					this.Invoke( new Action( delegate ( )
					{
						this.Close( );
					} ) );
				}
				else
				{
					this.Close( );
				}
			} )
			{
				IsBackground = true
			};

			closeWait.Start( );
		}

		private void Welcome_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // Top line drawing
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // Left line drawing
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // Right line drawing
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
		}
	}
}
