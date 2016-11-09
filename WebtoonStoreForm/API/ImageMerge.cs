using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebtoonStoreForm.API
{
	static class ImageMerge
	{
		public static void Merge( string dir )
		{
			string[ ] files = Directory.GetFiles( dir + @"\이미지\", "image_*.png" );

			Array.Sort( files, new Sort.NaturalStringComparer( ) );

			int maxW = 0;
			int totalH = 0;

			foreach ( string i in files )
			{
				System.Drawing.Image img = Bitmap.FromFile( i );

				totalH += img.Size.Height;

				if ( maxW < img.Size.Width )
				{
					maxW = img.Size.Width;
				}
			}

			Bitmap bmap = new Bitmap( maxW, totalH );
			Graphics g = Graphics.FromImage( bmap );

			int y = 0;
			foreach ( string i in files )
			{
				System.Drawing.Image img = Bitmap.FromFile( i );

				g.DrawImage( img, 0, y );

				y += img.Size.Height;
			}

			bmap.Save( dir + @"\합체.png", System.Drawing.Imaging.ImageFormat.Png );
		}
	}
}
