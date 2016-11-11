using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebtoonDownloader.API;

namespace WebtoonDownloader.Interface
{
	public partial class CopyrightAgree : Form
	{
		private bool isKoreanLanguageLicenseVer = false;
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.outlineColor )
		{
			Width = 1
		};

		public CopyrightAgree( )
		{
			InitializeComponent( );
		}

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			Application.Exit( );
		}

		private void AGREE_BUTTON_Click( object sender, EventArgs e )
		{
			if ( NotifyBoxResult.Yes == NotifyBox.Show( this, "경고",
				"본 소프트웨어 저작자 혹은 저작권자는 이 소프트웨어와 연관되어 발생하는 어떠한 법적 문제에 책임을 지지 않습니다.", NotifyBoxType.YesNo, NotifyBoxIcon.Warning ) )
			{
				GlobalVar.copyrightAgree = true;
				this.Close( );
			}
		}

		private void DISAGREE_BUTTON_Click( object sender, EventArgs e )
		{
			Application.Exit( );
		}

		private void APP_TITLE_BAR_Paint( object sender, PaintEventArgs e )
		{
			int w = this.APP_TITLE_BAR.Width, h = this.APP_TITLE_BAR.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // Top line drawing
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // Left line drawing
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // Right line drawing
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
		}

		private void CopyrightAgree_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // Top line drawing
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // Left line drawing
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // Right line drawing
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
		}

		private void APP_TITLE_BAR_MouseDown( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				startPoint = e.Location;
			}
		}

		private void APP_TITLE_BAR_MouseMove( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				this.Location = new Point(
					this.Left - ( startPoint.X - e.X ),
					Math.Max( this.Top - ( startPoint.Y - e.Y ), Screen.FromHandle( this.Handle ).WorkingArea.Top )
				);
			}
		}

		private void CopyrightAgree_Load( object sender, EventArgs e )
		{
			// 문법 오류를 막기 위해 원문의 " 를 ###로 수정
			string engLicenseHTML = @"<!DOCTYPE html>
			<html lang='en'>
				<head>
					<meta http-equiv='Content-type' content='text/html; charset=UTF-8'>
					<title>MIT License</title>
					<style>
						#license-container {
							padding: 15px;
							margin: 0px;
							width: 543px;
							border: 1px solid #bcbcbc;
						}

						html, body {
							margin: 0;
							width: 100%;
							height: 100%;
						}

						body, table, div, p
						{
							text-align: center;
							font-family: 'Malgun Gothic', '맑은 고딕', 'Arial';
						}
					</style>
				</head>
	
				<body>
					<div id='license-container'>
						<p style='font-weight: bold; font-size: 15px;'>MIT License</p>
						<p style='font-weight: bold; font-size: 13px;  margin: -10px'>Copyright (c) 2016 DeveloFOX Studio</p>
						<p style='font-weight: normal; font-size: 13px;' >
						Permission is hereby granted, free of charge, to any person obtaining a copy
						of this software and associated documentation files (the ###Software###), to deal
						in the Software without restriction, including without limitation the rights
						to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
						copies of the Software, and to permit persons to whom the Software is
						furnished to do so, subject to the following conditions:<br><br>

						<b>The above copyright notice and this permission notice shall be included in all
						copies or substantial portions of the Software.</b><br><br>

						THE SOFTWARE IS PROVIDED ###AS IS###, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
						IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
						FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
						<b>THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
						LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
						OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
						SOFTWARE.</b>
						</p>
					</div>
				</body>
			</html>";

			copyrightHTMLText.DocumentText = "0";
			copyrightHTMLText.Document.OpenNew( true );
			copyrightHTMLText.Document.Write( engLicenseHTML.Replace( "###", "\"" ) );
			copyrightHTMLText.Refresh( );

			AGREE_BUTTON.Enabled = false;
			AGREE_BUTTON.ButtonText = "5초 후에 동의할 수 있습니다.";

			int tickNum = 5;

			Timer agreeButtonActiveTick = new Timer( )
			{
				Interval = 1000
			};
			agreeButtonActiveTick.Tick += delegate ( object sender2, EventArgs e2 )
			{
				tickNum--;

				AGREE_BUTTON.ButtonText = tickNum + "초 후에 동의할 수 있습니다.";

				if ( tickNum <= 0 )
				{
					AGREE_BUTTON.Enabled = true;
					AGREE_BUTTON.ButtonText = "동의";

					agreeButtonActiveTick.Stop( );
					agreeButtonActiveTick.Dispose( );
				}
			};
			agreeButtonActiveTick.Start( );
		}

		private void showAnotherLanguageButton_Click( object sender, EventArgs e )
		{
			isKoreanLanguageLicenseVer = !isKoreanLanguageLicenseVer;

			if ( isKoreanLanguageLicenseVer )
			{
				// 문법 오류를 막기 위해 원문의 " 를 ###로 수정
				string korLicenseHTML = @"<!DOCTYPE html>
				<html lang='ko'>
					<head>
						<meta http-equiv='Content-type' content='text/html; charset=UTF-8'>
						<title>MIT License</title>
						<style>
							#license-container {
								padding: 15px;
								margin: 0px;
								width: 543px;
								border: 1px solid #bcbcbc;
							}

							html, body {
								margin: 0;
								width: 100%;
								height: 100%;
							}

							body, table, div, p
							{
								text-align: center;
								font-family: 'Malgun Gothic', '맑은 고딕', 'Arial';
							}
						</style>
					</head>
	
					<body>
						<div id='license-container'>
							<p style='font-weight: bold; font-size: 15px;'>MIT 라이센스</p>
							<p style='font-weight: bold; font-size: 13px;  margin: -10px'>Copyright (c) 2016 DeveloFOX Studio</p>
							<p style='font-weight: normal; font-size: 13px;' >
							이 문서에 기하여, 이 소프트웨어와 이와 연관된 모든 문서(이하 ###소프트웨어###라 한다)의 복제본을 보유하게 되는 모든 사용자에 대하여, 다음의 권한이 무상으로 부여된다.
							소프트웨어의 사용, 복제, 변경, 통합, 발행, 배포, 재실시, 판매에 대한 제약을 포함한 어떠한 제약 없이 본 소프트웨어를 취급할 수 있으며, 이는 제3자에 대한 소프트웨어 지급 시에도 동일하게 적용된다.
							단, 이 모든 사항은 아래의 조건하에 적용된다.<br><br>

							<b>위 저작권 표시와 본 허가조항은 소프트웨어의 모든 복제본 혹은 중요한 부분에 포함되어야 한다.</b><br><br>

							소프트웨어는 ###있는 그대로### 제공된다. 판매 적격성, 특정 용도에 대한 적합성, 준법성, 혹은 그 이상의 범위를 포함한 사항에 있어서, 명시적 혹은 암시적인 어떠한 보증도 하지 않는다.
							<br><br><b>계약, 불법행위 등의 과정상의 개입 여부에 상관없이 어떠한 상황에서도, 본 소프트웨어의 저작자 혹은 저작권자는, 소프트웨어에서 혹은 소프트웨어와 연관되어 발생하는,
							또한 사용과정 중 혹은 기타 거래 도중 발생하는 어떠한 소유권 청구, 피해, 혹은 기타 다른 법적 책임에 대해서도 책임을 지지 않는다.</b>
							</p>
						</div>
					</body>
				</html>";

				copyrightHTMLText.DocumentText = "0";
				copyrightHTMLText.Document.OpenNew( true );
				copyrightHTMLText.Document.Write( korLicenseHTML.Replace( "###", "\"" ) );
				copyrightHTMLText.Refresh( );

				showAnotherLanguageButton.ButtonText = "사용권 원문 보기";
			}
			else
			{
				// 문법 오류를 막기 위해 원문의 " 를 ###로 수정
				string engLicenseHTML = @"<!DOCTYPE html>
				<html lang='en'>
					<head>
						<meta http-equiv='Content-type' content='text/html; charset=UTF-8'>
						<title>MIT License</title>
						<style>
							#license-container {
								padding: 15px;
								margin: 0px;
								width: 543px;
								border: 1px solid #bcbcbc;
							}

							html, body {
								margin: 0;
								width: 100%;
								height: 100%;
							}

							body, table, div, p
							{
								text-align: center;
								font-family: 'Malgun Gothic', '맑은 고딕', 'Arial';
							}
						</style>
					</head>
	
					<body>
						<div id='license-container'>
							<p style='font-weight: bold; font-size: 15px;'>MIT License</p>
							<p style='font-weight: bold; font-size: 13px;  margin: -10px'>Copyright (c) 2016 DeveloFOX Studio</p>
							<p style='font-weight: normal; font-size: 13px;' >
							Permission is hereby granted, free of charge, to any person obtaining a copy
							of this software and associated documentation files (the ###Software###), to deal
							in the Software without restriction, including without limitation the rights
							to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
							copies of the Software, and to permit persons to whom the Software is
							furnished to do so, subject to the following conditions:<br><br>

							<b>The above copyright notice and this permission notice shall be included in all
							copies or substantial portions of the Software.</b><br><br>

							THE SOFTWARE IS PROVIDED ###AS IS###, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
							IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
							FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
							<b>THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
							LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
							OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
							SOFTWARE.</b>
							</p>
						</div>
					</body>
				</html>";

				copyrightHTMLText.DocumentText = "0";
				copyrightHTMLText.Document.OpenNew( true );
				copyrightHTMLText.Document.Write( engLicenseHTML.Replace( "###", "\"" ) );
				copyrightHTMLText.Refresh( );

				showAnotherLanguageButton.ButtonText = "사용권 한글 번역본 보기";
			}
		}

		private void licenseDetailShowButton_Click( object sender, EventArgs e )
		{
			if ( NotifyBoxResult.Yes == NotifyBox.Show( this, "웹 브라우저 실행 안내",
				"사용권에 대한 자세한 정보가 웹 브라우저에서 열립니다.", NotifyBoxType.YesNo, NotifyBoxIcon.Information ) )
			{
				try
				{
					System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo( "en-US" );

					System.Diagnostics.Process.Start( "https://ko.wikipedia.org/wiki/MIT_%ED%97%88%EA%B0%80%EC%84%9C" );
				}
				catch ( Exception ex )
				{
					Utility.WriteErrorLog( ex.Message, "Exception" );
					NotifyBox.Show( this, "오류", "알 수 없는 오류가 발생했습니다, 로그 파일을 참고하세요.", NotifyBoxType.OK, NotifyBoxIcon.Error );
				}
			}
		}
	}
}
