using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebtoonDownloader.API
{
	static class Update
	{
		public enum UpdateCheckResult
		{
			IsLatestVersion,
			UpdateNeed,
			ServerError,
			UnknownError,
			NotChecked
		}

		public static UpdateCheckResult Check( )
		{
			try
			{
				System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo( "en-US" );

				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "https://raw.githubusercontent.com/DeveloFOX-Studio/Webtoon-Downloader/master/Update/latest_version.txt" );
				request.Method = "GET";

				using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
				{
					using ( Stream responseStream = response.GetResponseStream( ) )
					{
						using ( StreamReader reader = new StreamReader( responseStream, Encoding.UTF8 ) )
						{
							string htmlResult = reader.ReadToEnd( );

							Version version = System.Reflection.Assembly.GetExecutingAssembly( ).GetName( ).Version;

							if ( htmlResult == ( version.Major + "." + version.Minor + "." + version.Build + "." + version.Revision ) )
							{
								return UpdateCheckResult.IsLatestVersion;
							}
							else
							{
								return UpdateCheckResult.UpdateNeed;
							}
						}
					}
				}
			}
			catch ( WebException ex )
			{
				Utility.WriteErrorLog( ex.Message, "WebException" );

				return UpdateCheckResult.ServerError;
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, "Exception" );
			}

			return UpdateCheckResult.UnknownError;
		}
	}
}
