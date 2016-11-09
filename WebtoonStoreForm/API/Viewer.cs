using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebtoonStoreForm.API
{
	static class Viewer
	{
		public static void Create( string directory, WebtoonPageInformation info )
		{
			if ( File.Exists( "htmlBase.html" ) )
			{
				string baseHTML = File.ReadAllText( "htmlBase.html", Encoding.UTF8 );

				baseHTML = baseHTML.Replace( "#title", info.title );

				string[ ] files = Directory.GetFiles( directory + @"\이미지\", "image_*.png" );

				Array.Sort( files, new Sort.NaturalStringComparer( ) );

				StringBuilder sb = new StringBuilder( );

				foreach ( string i in files )
				{
					sb.Append( @"<img src = '이미지/" + Path.GetFileName( i ) + "' />" + Environment.NewLine );
				}

				baseHTML = baseHTML.Replace( "#images", sb.ToString( ) );

				File.WriteAllText( directory + "\\웹툰 뷰어.html", baseHTML, Encoding.UTF8 );
			}
		}
	}
}
