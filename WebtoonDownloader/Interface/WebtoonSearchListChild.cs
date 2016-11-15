using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebtoonDownloader.Interface
{
	public partial class WebtoonSearchListChild : UserControl
	{
		public event Action<WebtoonSearchResult> Selected;
		private WebtoonSearchResult info;

		private Pen lineDrawer = new Pen( GlobalVar.outlineColor )
		{
			Width = 1
		};

		public WebtoonSearchListChild( WebtoonSearchResult info )
		{
			InitializeComponent( );

			this.info = info;

			webtoonTitleLabel.Text = info.title;
			webtoonAuthorLabel.Text = info.author;
			webtoonDescriptionLabel.Text = info.description;

			webtoonUploadLabel.Text = "마지막 업로드 일 : " + info.uploadDate;
			webtoonNumLabel.Text = "총 " + info.num + "화";
			webtoonGenreLabel.Text = info.genre + " 장르";

			try
			{
				webtoonThumbnailImage.Load( info.thumbnailURL );
			}
			catch ( Exception )
			{
				webtoonThumbnailImage.Image = null;
			}
		}

		private void WebtoonSearchListChild_Load( object sender, EventArgs e )
		{

		}

		private void WebtoonSearchListChild_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
		}

		private void webtoonThumbnailImage_Paint( object sender, PaintEventArgs e )
		{
			int w = this.webtoonThumbnailImage.Width, h = this.webtoonThumbnailImage.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // Top line drawing
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // Left line drawing
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // Right line drawing
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
		}

		private void selectButton_Click( object sender, EventArgs e )
		{
			Selected.Invoke( info );
		}
	}
}
