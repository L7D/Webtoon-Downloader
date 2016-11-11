using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebtoonDownloader
{
	static class GlobalEnum
	{
		public const string blankThumbnailURL = "http://static.comic.naver.net/staticImages/COMICWEB/NAVER/img/common/non71_41.gif";
	}

	static class GlobalVar
	{
		public static bool copyrightAgree = false;
		public static string viewerBaseHTMLString;
		public static System.Drawing.Color outlineColor = System.Drawing.Color.DarkGray;

		static GlobalVar( )
		{
			//if ( File.Exists( System.Windows.Forms.Application.StartupPath ))
			//string baseHTML = File.ReadAllText( "htmlBase.html", Encoding.UTF8 );
			viewerBaseHTMLString = @"
				<!DOCTYPE html>
<html lang='ko'>
	<head>
		<meta http-equiv='Content-type' content='text/html; charset=UTF-8'>

		<title>웹툰 뷰어 - #title</title>
		<link rel='shortcut icon' href='http://www.naver.com/favicon.ico?1' type='image/x-icon' />
		<link rel='icon' href='http://www.naver.com/favicon.ico?1' type='image/x-icon' />
		<style>
			@import url( 'http://fonts.googleapis.com/earlyaccess/nanumgothic.css' );
			
			#webtoonDownloader-container {
				width: 940px;
				margin: 0px auto;
				padding: 20px;
				border: 1px solid #bcbcbc;
			}
			
			#webtoonDownloader-header {
				padding: 10px;
				text-align: center;
			}
		  
			#webtoonDownloader-content {
				width: 100% - 10px;
				padding: 20px;
				margin-bottom: 20px;
				float: center;
			}
		  
			#webtoonDownloader-footer {
				clear: both;
				padding: 0px;
				text-align: center;
			}
			
			img
			{
				display: block;
				margin-left: auto;
				margin-right: auto;
			}
			
			body, table, div, p
			{
				font-family:  'Nanum Gothic', 'Malgun Gothic', '맑은 고딕', 'Arial';
			}
		</style>
	</head>
	
	<body>
		<div id='webtoonDownloader-container'>
			<div id='webtoonDownloader-header'>
				<img src='썸네일.jpg' />
				<h3>웹툰 뷰어 - #title</h3>
			</div>
			
			<div id='webtoonDownloader-content'>
				#images
			</div>
			
			<div id='webtoonDownloader-footer'>
				<p><b>웹툰 다운로더에 의해 생성되었습니다.</b></p>
				<p><b>Copyright © DeveloFOX Studio 2016</b></p>
			</div>
		</div>
	</body>
</html>";
		}
	}
}
