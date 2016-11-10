using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WebtoonStoreForm.API
{
	// http://stackoverflow.com/questions/248603/natural-sort-order-in-c-sharp/248613#248613
	// http://pullthelever.tistory.com/479
	static class Sort
	{
		[System.Security.SuppressUnmanagedCodeSecurity]
		internal static class SafeNativeMethods
		{
			[System.Runtime.InteropServices.DllImport( "shlwapi.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode )]
			public static extern int StrCmpLogicalW( string psz1, string psz2 );
		}

		public sealed class NaturalStringComparer : IComparer<string>
		{
			public int Compare( string a, string b )
			{
				return SafeNativeMethods.StrCmpLogicalW( a, b );
			}
		}
	}

	static class Utility
	{
		// 폴더 이름으로 불가능한 문자들을 _로 변경
		public static string StripFolderName( string folderName )
		{
			return System.Text.RegularExpressions.Regex.Replace( folderName, "[\\\\/:*?\"<>|]", "_" );
		}

		// Lerp (Linear interpolation, 선형보간법) 
		// p 의 값이 0에 가까워질수록 ( a - b ) 에 비례하여 중간 값이 커진다 (애니메이션이 빨라진다)
		// p 의 값이 1에 가까워질수록 ( a - b ) 에 비례하여 중간 값이 작아진다 (애니메이션이 느려진다)
		// ( p 의 값이 0 ~ 1F )
		// http://stackoverflow.com/questions/33044848/c-sharp-lerping-from-position-to-position
		// http://dodnet.tistory.com/993
		public static float Lerp( float a, float b, float p )
		{
			return a * p + b * ( 1 - p );
		}

		public static Color LerpColor( Color a, Color b, float p )
		{
			float newR = 0, newG = 0, newB = 0, newA =0;

			newR = a.R * p + b.R * ( 1 - p );
			newG = a.G * p + b.G * ( 1 - p );
			newB = a.B * p + b.B * ( 1 - p );
			newA = a.A * p + b.A * ( 1 - p );

			//return Color.FromArgb( (int)Math.Round( newR ), ( int ) newG, ( int ) newB );
			return Color.FromArgb( ( int ) Math.Round( newA ), ( int ) Math.Round( newR ), ( int ) Math.Round( newG ), ( int ) Math.Round( newB ) );
		}

		// https://msdn.microsoft.com/ko-kr/library/8kb3ddd4(v=vs.110).aspx
		// http://www.codeproject.com/Tips/606379/Caller-Info-Attributes-in-Csharp
		public static void WriteErrorLog( string errorString, string severityString = "NORMAL", [CallerMemberName] string debugTrace_CallerName = null,
		[CallerFilePath] string debugTrace_CallerFilePath = null,
		[CallerLineNumber] int debugTrace_CallerLine = -1 )
		{
			string path = System.Windows.Forms.Application.StartupPath + @"\log\" + DateTime.Now.ToString( "yyyy-MM-dd" );

			if ( !Directory.Exists( path ) )
			{
				Directory.CreateDirectory( path );
			}

			File.AppendAllText( path + @"\error.log",
				string.Format( "WebtoonDownloader [{0}] #{1}# : {2} <{3} -> {4} method:{5}>\r\n",
					DateTime.Now.ToString( "HH:mm:ss:fffffff" ),
					severityString,
					errorString,
					debugTrace_CallerName,
					Path.GetFileName( debugTrace_CallerFilePath ),
					debugTrace_CallerLine
				),
			Encoding.UTF8 );
		}
	}
}
