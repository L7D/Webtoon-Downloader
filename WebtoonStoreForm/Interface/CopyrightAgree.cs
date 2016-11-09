using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebtoonStoreForm.Interface
{
	public partial class CopyrightAgree : Form
	{
		private Point startPoint;

		public CopyrightAgree( )
		{
			InitializeComponent( );
		}

		private void APP_TITLE_PANEL_MouseMove( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				Rectangle ang = Screen.FromHandle( this.Handle ).WorkingArea;
				this.Location = new Point(
					this.Left - ( startPoint.X - e.X ),
					Math.Max( this.Top - ( startPoint.Y - e.Y ), ang.Top )
				);
			}
		}

		private void APP_TITLE_PANEL_MouseDown( object sender, MouseEventArgs e )
		{
			startPoint = e.Location;
		}

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			Application.Exit( );
		}

		private void AGREE_BUTTON_Click( object sender, EventArgs e )
		{
			if ( DialogResult.Yes == MessageBox.Show( this, "이 프로그램의 불법적인 사용으로 인해 발생하는 모든 법적 문제는 사용자 본인의 책임입니다, 동의하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Warning ) )
			{
				GlobalVar.copyrightAgree = true;
				this.Close( );
			}
		}

		private void DISAGREE_BUTTON_Click( object sender, EventArgs e )
		{
			Application.Exit( );
		}
	}
}
