using System;
using System.IO;
using System.Text;

namespace WebtoonDownloader.API
{
	static class Viewer
	{
		public enum ViewerCreateResult
		{
			Success,
			DirectoryNotFoundException,
			IOException,
			UnauthorizedAccessException,
			Unknown
		}

		public static ViewerCreateResult Create( string directory, WebtoonPageInformation info )
		{
			try
			{
				System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo( "en-US" );

				string[ ] files = Directory.GetFiles( directory + @"\이미지", "image_*.jpg", SearchOption.TopDirectoryOnly );
				StringBuilder htmlSB = new StringBuilder( GlobalVar.viewerBaseHTMLString );

				htmlSB.Replace( "#title", info.title );

				// 이미지들 이름에 따라 정렬 (Natural Sort)
				Array.Sort( files, new Sort.NaturalStringComparer( ) );

				StringBuilder imageSB = new StringBuilder( );

				foreach ( string i in files )
				{
					imageSB.AppendLine( "<img src = '이미지/" + Path.GetFileName( i ) + "' />" );
				}

				htmlSB.Replace( "#images", imageSB.ToString( ) );

				File.WriteAllText( directory + "\\웹툰 뷰어.html", htmlSB.ToString( ), Encoding.UTF8 );

				return ViewerCreateResult.Success;
			}
			catch ( DirectoryNotFoundException ex )
			{
				Utility.WriteErrorLog( ex.Message, "DirectoryNotFoundException" );
				return ViewerCreateResult.DirectoryNotFoundException;
			}
			catch ( IOException ex )
			{
				Utility.WriteErrorLog( ex.Message, "IOException" );
				return ViewerCreateResult.IOException;
			}
			catch ( UnauthorizedAccessException ex )
			{
				Utility.WriteErrorLog( ex.Message, "UnauthorizedAccessException" );
				return ViewerCreateResult.UnauthorizedAccessException;
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, "Exception" );
				return ViewerCreateResult.Unknown;
			}
		}
	}
}
