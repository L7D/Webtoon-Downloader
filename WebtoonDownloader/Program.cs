using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebtoonDownloader.API;
using WebtoonDownloader.Interface;

namespace WebtoonDownloader
{
	static class Program
	{
		/// <summary>
		/// 해당 응용 프로그램의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main( )
		{
			try
			{
				string[ ] dllList = {
					"HtmlAgilityPack"
				};

				for ( int i = 0; i < dllList.Length; i++ )
				{
					System.Reflection.Assembly.Load( dllList[ i ] ).GetName( );
				}
			}
			catch ( Exception )
			{
				NotifyBox.Show( null, "심각한 오류", "DLL를 불러올 수 없습니다, 프로그램을 재설치 해주세요.", NotifyBoxType.OK, NotifyBoxIcon.Error );
				return;
			}

			Application.EnableVisualStyles( );
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new Main( ) );
		}
	}
}
