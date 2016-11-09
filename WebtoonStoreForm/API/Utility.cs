using System;
using System.Collections.Generic;
using System.Linq;
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
		public static string StripFolderName( string name )
		{
			return System.Text.RegularExpressions.Regex.Replace( name, "[\\\\/:*?\"<>|]", "_" );
		}
	}
}
