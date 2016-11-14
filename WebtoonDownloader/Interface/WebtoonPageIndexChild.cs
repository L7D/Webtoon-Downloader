using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebtoonDownloader.Interface
{
	public partial class WebtoonPageIndexChild : UserControl
	{
		public event Action<int> PageClicked;
		private int index;

		public WebtoonPageIndexChild( int index )
		{
			InitializeComponent( );

			this.index = index;
			this.INDEX_BUTTON.ButtonText = index.ToString( );
		}

		private void INDEX_BUTTON_Click( object sender, EventArgs e )
		{
			PageClicked.Invoke( index );
		}
	}
}
