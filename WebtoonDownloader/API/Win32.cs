using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WebtoonDownloader.API
{
	static class Win32
	{
		// http://blog.bloodcat.com/153
		[DllImport( "advapi32.dll" )]
		public static extern void InitiateSystemShutdown( string lpMachineName, string lpMessage, int dwTimeout, bool bForceAppsClosed, bool bRebootAfterShutdown );
	
	
	}
}
