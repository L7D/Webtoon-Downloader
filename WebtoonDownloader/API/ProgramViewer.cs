using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebtoonDownloader.API
{
	static class ProgramViewer
	{
		public static void CreateDataFile( string directory, string dataFileName, string webtoonTitle, string title, string starRate, string uploadDate, byte[ ] thumbnailImageData, List<byte[ ]> webtoonImageData )
		{
			StringBuilder dataString = new StringBuilder( );

			dataString.AppendLine( Convert.ToBase64String( Encoding.UTF8.GetBytes( GlobalVar.VDATACurrentVersion ) ) );
			dataString.AppendLine( Convert.ToBase64String( Encoding.UTF8.GetBytes( webtoonTitle ) ) );
			dataString.AppendLine( Convert.ToBase64String( Encoding.UTF8.GetBytes( title ) ) );
			dataString.AppendLine( Convert.ToBase64String( Encoding.UTF8.GetBytes( starRate ) ) );
			dataString.AppendLine( Convert.ToBase64String( Encoding.UTF8.GetBytes( uploadDate ) ) );
			dataString.AppendLine( Convert.ToBase64String( thumbnailImageData ) );

			// 웹툰 이미지 데이터를 저장.
			int count = 0;
			foreach ( byte[ ] i in webtoonImageData )
			{
				if ( webtoonImageData.Count == count )
					dataString.Append( Convert.ToBase64String( i ) );
				else
					dataString.AppendLine( Convert.ToBase64String( i ) );

				count++;
			}

			byte[ ] dataByte = Encoding.UTF8.GetBytes( dataString.ToString( ) );

			using ( MemoryStream ms = new MemoryStream( ) )
			{
				using ( DeflateStream ds = new DeflateStream( ms, CompressionMode.Compress ) )
				{
					ds.Write( dataByte, 0, dataByte.Length );
				}

				File.WriteAllBytes( directory + @"\" + dataFileName + ".vdata", ms.ToArray( ) );
			}
		}
	}
}
