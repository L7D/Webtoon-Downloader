using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebtoonDownloader.Interface;

namespace WebtoonDownloader.API
{
	public enum NotifyBoxResult
	{
		Yes,
		No,
		OK,
		Null
	}

	public enum NotifyBoxType
	{
		YesNo,
		OK
	}

	public enum NotifyBoxIcon
	{
		Warning,
		Error,
		Information,
		Question
	}

	public static class NotifyBox
	{
		public static NotifyBoxResult Show( System.Windows.Forms.Form parent, string title = "웹툰 다운로더", string message = "메세지", NotifyBoxType type = NotifyBoxType.OK, NotifyBoxIcon icon = NotifyBoxIcon.Information )
		{
			NotifyBoxResult returnType = NotifyBoxResult.Null;

			NotifyBoxInterface Form = new NotifyBoxInterface( title, message, type, icon );
			Form.Owner = parent;
			Form.EventBack += ( receivedType ) =>
			{
				returnType = receivedType;
			};

			Form.ShowDialog( );

			return returnType;
		}
	}
}
