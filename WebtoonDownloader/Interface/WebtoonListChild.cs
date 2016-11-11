using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebtoonDownloader.API;

namespace WebtoonDownloader.Interface
{
	public partial class WebtoonListChild : UserControl
	{
		public WebtoonPageInformation info;
		public bool blocked = false;
		private SolidBrush BackgroundDrawer = new SolidBrush( Color.FromArgb( 0, Color.Orange ) );
		private Timer highlightTimer;
		private Timer blockAnimationTimer;
		private Pen lineDrawer = new Pen( GlobalVar.outlineColor )
		{
			Width = 1
		};

		public WebtoonListChild( WebtoonPageInformation info )
		{
			InitializeComponent( );

			this.SetStyle( ControlStyles.OptimizedDoubleBuffer, true );

			this.info = info;

			webtoonTitleLabel.Text = info.title;
			webtoonStarRateLabel.Text = info.starRate;
			webtoonUploadDateLabel.Text = info.uploadDate;

			try
			{
				thumbnailImage.Load( info.thumbnailURL );
			}
			catch ( Exception )
			{
				thumbnailImage.Image = null;
			}
		}

		public void Block( bool status )
		{
			if ( blockAnimationTimer != null )
			{
				blockAnimationTimer.Stop( );
				blockAnimationTimer.Dispose( );
				blockAnimationTimer = null;
			}

			BackgroundDrawer = new SolidBrush( Color.FromArgb( BackgroundDrawer.Color.A, Color.Orange ) );

			blockAnimationTimer = new Timer( )
			{
				Interval = 10
			};
			blockAnimationTimer.Tick += delegate( object sender, EventArgs e )
			{
				if ( BackgroundDrawer.Color.A == ( status ? 200 : 0 ) )
				{
					blockAnimationTimer.Stop( );
					blockAnimationTimer.Dispose( );
					blockAnimationTimer = null;
					return;
				}

				float a = BackgroundDrawer.Color.A;

				a = Utility.Lerp( a, ( status ? a + 25 : a - 25 ), 0.1F );

				BackgroundDrawer.Color = Color.FromArgb( Utility.Clamp( ( int ) a, 200, 0 ), BackgroundDrawer.Color );

				this.Invalidate( );
			};

			blockAnimationTimer.Start( );
		}

		public void Highlight( )
		{
			if ( blockAnimationTimer != null )
			{
				blockAnimationTimer.Stop( );
				blockAnimationTimer.Dispose( );
				blockAnimationTimer = null;
			}

			if ( highlightTimer != null )
			{
				highlightTimer.Stop( );
				highlightTimer.Dispose( );
				highlightTimer = null;
			}

			BackgroundDrawer = new SolidBrush( Color.PaleTurquoise );

			highlightTimer = new Timer( )
			{
				Interval = 10
			};
			highlightTimer.Tick += delegate( object sender, EventArgs e )
			{
				if ( BackgroundDrawer.Color.A == 0 )
				{
					highlightTimer.Stop( );
					highlightTimer.Dispose( );
					highlightTimer = null;
					return;
				}

				float a = BackgroundDrawer.Color.A;

				a = Utility.Lerp( a, a - 10, 0.7F );

				BackgroundDrawer.Color = Color.FromArgb( Utility.Clamp( ( int ) a, 255, 0 ), BackgroundDrawer.Color );

				this.Invalidate( );
			};

			highlightTimer.Start( );
		}

		protected override void OnPaint( PaintEventArgs e )
		{
			base.OnPaint( e );

			e.Graphics.FillRectangle( this.BackgroundDrawer, e.ClipRectangle );
		}

		private void WebtoonListChild_Load( object sender, EventArgs e )
		{
			toolTipControl.SetToolTip( blockButton, "이 화를 다운로드에서 제외시킵니다." );
		}

		private void thumbnailImage_Paint( object sender, PaintEventArgs e )
		{
			int w = this.thumbnailImage.Width, h = this.thumbnailImage.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // Top line drawing
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // Left line drawing
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // Right line drawing
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
		}

		private void WebtoonListChild_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
		}
		
		private void blockButton_Click( object sender, EventArgs e )
		{
			blocked = !blocked;

			Block( blocked );

			if ( blocked )
			{
				toolTipControl.SetToolTip( blockButton, "이 화를 다운로드에 포함시킵니다." );

				this.blockButton.EnterStateBackgroundColor = System.Drawing.Color.DarkGray;
				this.blockButton.NormalStateBackgroundColor = System.Drawing.Color.DarkOrange;
			}
			else
			{
				toolTipControl.SetToolTip( blockButton, "이 화를 다운로드에서 제외시킵니다." );

				this.blockButton.EnterStateBackgroundColor = System.Drawing.Color.DarkOrange;
				this.blockButton.NormalStateBackgroundColor = System.Drawing.Color.DarkGray;
			}
		}
	}
}
