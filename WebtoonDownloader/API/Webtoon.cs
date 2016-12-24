using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using HtmlAgilityPack;
using WebtoonDownloader.API;

namespace WebtoonDownloader
{
	public struct WebtoonBasicInformation
	{
		public string title;
		public string description;
		public string thumbnailURL;
		public string url;
		public int totalNum;
		public List<WebtoonPageInformation> pages;
		public bool errorChecked;

		public WebtoonBasicInformation( string title, string description, string thumbnailURL, string url, int totalNum, List<WebtoonPageInformation> pages, bool errorChecked = false )
		{
			this.title = title;
			this.description = description;
			this.thumbnailURL = thumbnailURL;
			this.url = url;
			this.totalNum = totalNum;
			this.pages = pages;
			this.errorChecked = errorChecked;
		}
	}

	public struct WebtoonPageInformation
	{
		public string title;
		public string thumbnailURL;
		public string url;
		public string starRate;
		public int num;
		public string uploadDate;

		public WebtoonPageInformation( string title, string thumbnailURL, string url, string starRate, int num, string uploadDate )
		{
			this.title = title;
			this.thumbnailURL = thumbnailURL;
			this.url = url;
			this.starRate = starRate;
			this.num = num;
			this.uploadDate = uploadDate;
		}
	}

	public struct WebtoonSearchResult
	{
		public string title;
		public string author;
		public string url;
		public int num;
		public string uploadDate;
		public string type;
		public string genre;
		public string description;
		public string thumbnailURL;
		public bool adultWebtoon;

		public WebtoonSearchResult( string title, string author, string url, int num, string uploadDate, string type, string genre, string description, string thumbnailURL, bool adultWebtoon = false )
		{
			this.title = title;
			this.author = author;
			this.url = url;
			this.num = num;
			this.uploadDate = uploadDate;
			this.type = type;
			this.genre = genre;
			this.description = description;
			this.thumbnailURL = thumbnailURL;
			this.adultWebtoon = adultWebtoon;
		}
	}

	public struct WebtoonSearchResultDetail
	{
		public string description;
		public string thumbnailURL;

		public WebtoonSearchResultDetail( string description, string thumbnailURL )
		{
			this.description = description;
			this.thumbnailURL = thumbnailURL;
		}
	}

	static class Webtoon
	{
		public static string BaseDirectory
		{
			get;
			set;
		}
		public static WebtoonBasicInformation? CurrentBaseInformation;
		public static bool OnlyDataMode;
		public static bool FastDownloadMode;
		public static List<int> DownloadBlockList = new List<int>( );
		public static event Action<string> StatusMessageLabelSet;
		public static event Action<string> ErrorMessageCall;
		public static event Action<bool> DownloadFinished;
		public static event Action<WebtoonPageInformation> DownloadTargetChanged;
		public static event Action<float> DownloadProgressChanged;
		public static Thread DownloadThread = null;

		public static bool IsValidFixURL( ref string url )
		{
			try
			{
				Uri newURI = new Uri( url );

				System.Collections.Specialized.NameValueCollection query = HttpUtility.ParseQueryString( newURI.Query );

				if ( newURI.GetLeftPart( UriPartial.Path ).ToLower( ) == "http://comic.naver.com/webtoon/list.nhn" && !string.IsNullOrEmpty( query.Get( "titleId" ) ) )
				{
					url = newURI.GetLeftPart( UriPartial.Path ) + "?titleId=" + query.Get( "titleId" );

					return true;
				}

				return false;
			}
			catch ( UriFormatException )
			{
				return false;
			}
		}

		public static int SearchMaxPage( string url )
		{
			try
			{
				System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo( "en-US" );

				url += "&page=999999999"; // 999999999 로 요청할 시 가장 뒤에 페이지로 이동

				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( url );
				request.Method = "GET";

				using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
				{
					using ( Stream responseStream = response.GetResponseStream( ) )
					{
						using ( StreamReader reader = new StreamReader( responseStream, Encoding.UTF8 ) )
						{
							string htmlResult = reader.ReadToEnd( );

							HtmlDocument document = new HtmlDocument( );
							document.LoadHtml( htmlResult );

							foreach ( HtmlNode i in document.DocumentNode.SelectNodes( "//strong" ) )
							{
								if ( i.GetAttributeValue( "class", "" ) == "page" )
								{
									foreach ( HtmlNode node2 in i.ChildNodes )
									{
										if ( node2.OriginalName == "em" && node2.GetAttributeValue( "class", "" ) == "num_page" )
										{
											return int.Parse( node2.InnerText );
										}
									}
								}
							}
						}
					}
				}
			}
			catch ( WebException ex )
			{
				if ( ex.Response == null )
				{
					Utility.WriteErrorLog( ex.Message, "WebException" );
					ErrorMessageCall.Invoke( "귀하의 인터넷 연결을 확인하세요." );
				}
				else
				{
					Utility.WriteErrorLog( ex.Message, "WebException" );
					ErrorMessageCall.Invoke( "서버에서 오류가 발생했습니다, " + ex.Response + " 오류 코드를 반환했습니다." );
				}
			}
			catch ( ThreadAbortException )
			{
				GC.Collect( 0, GCCollectionMode.Forced ); // 쓰레드가 강제 종료된 후 메모리를 정리하기 위해 GC 강제 실행
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, "Exception" );
				ErrorMessageCall.Invoke( "알 수 없는 오류가 발생했습니다, 로그 파일을 참고하세요." );
			}

			return -1;
		}

		private static WebtoonSearchResultDetail SearchDetailRequest( string url )
		{
			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( url );
				request.Method = "GET";

				using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
				{
					using ( Stream responseStream = response.GetResponseStream( ) )
					{
						using ( StreamReader reader = new StreamReader( responseStream, Encoding.UTF8 ) )
						{
							string htmlResult = reader.ReadToEnd( );

							HtmlDocument document = new HtmlDocument( );
							document.LoadHtml( htmlResult );

							WebtoonSearchResultDetail returnInfo = new WebtoonSearchResultDetail( );

							int descStart = htmlResult.IndexOf( "meta property=\"og:description\"" );

							string[ ] trashDatas = htmlResult.Substring( descStart, htmlResult.IndexOf( ">", descStart ) - descStart )
								.Split( new char[ 1 ] { '"' }, StringSplitOptions.RemoveEmptyEntries );

							string desc = "";

							try
							{
								for ( int i = 3; i < trashDatas.Length; i++ )
								{
									desc += trashDatas[ i ] + Environment.NewLine;
								}
							}
							catch ( IndexOutOfRangeException ) { }

							returnInfo.description = HttpUtility.HtmlDecode( desc.Trim( ) );

							foreach ( HtmlNode node in document.DocumentNode.SelectNodes( "//meta" ) )
							{
								switch ( node.GetAttributeValue( "property", "" ) )
								{
									case "og:image": // 해당 웹툰 썸네일 이미지
										returnInfo.thumbnailURL = node.GetAttributeValue( "content", "" ).Trim( );
										break;
								}
							}

							return returnInfo;
						}
					}
				}
			}
			catch ( WebException ex )
			{
				if ( ex.Response == null )
				{
					Utility.WriteErrorLog( ex.Message, "WebException" );
					ErrorMessageCall.Invoke( "귀하의 인터넷 연결을 확인하세요." );
				}
				else
				{
					Utility.WriteErrorLog( ex.Message, "WebException" );
					ErrorMessageCall.Invoke( "서버에서 오류가 발생했습니다, " + ex.Response + " 오류 코드를 반환했습니다." );
				}
			}
			catch ( ThreadAbortException )
			{
				GC.Collect( 0, GCCollectionMode.Forced ); // 쓰레드가 강제 종료된 후 메모리를 정리하기 위해 GC 강제 실행
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, "Exception" );
				ErrorMessageCall.Invoke( "알 수 없는 오류가 발생했습니다, 로그 파일을 참고하세요." );
			}

			return new WebtoonSearchResultDetail( );
		}

		private static List<WebtoonSearchResult> InternalSearch( string url )
		{
			List<WebtoonSearchResult> result = new List<WebtoonSearchResult>( );

			// *추가 사항*
			// oz 뷰어 사용한 애니메이션 웹툰 예외처리
			// bgm 있는 웹툰일 경우 같이 다운로드 (확실치 않음)
			// 미성년자 관람 불가 웹툰 로그인 폼 띄워서 인증

			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( url );
				request.Method = "GET";

				using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
				{
					using ( Stream responseStream = response.GetResponseStream( ) )
					{
						using ( StreamReader reader = new StreamReader( responseStream, Encoding.UTF8 ) )
						{
							string htmlResult = reader.ReadToEnd( );

							HtmlDocument document = new HtmlDocument( );
							document.LoadHtml( htmlResult );

							foreach ( HtmlNode i in document.DocumentNode.SelectNodes( "//ul" ) )
							{
								if ( i.GetAttributeValue( "class", "" ) == "resultList" )
								{
									foreach ( HtmlNode i2 in i.ChildNodes )
									{
										if ( i2.OriginalName == "li" )
										{
											WebtoonSearchResult data = new WebtoonSearchResult( );

											foreach ( HtmlNode i3 in i2.ChildNodes )
											{
												if ( i3.OriginalName == "h5" )
												{
													foreach ( HtmlNode i4 in i3.ChildNodes )
													{
														if ( i4.OriginalName == "a" )
														{
															data.title = i4.InnerText;
															data.url = "http://comic.naver.com" + i4.GetAttributeValue( "href", "" );
														}
														else if ( i4.OriginalName == "img" )
														{
															if ( i4.GetAttributeValue( "title", "" ) != "" )
															{
																data.type = i4.GetAttributeValue( "title", "" );
															}
														}
														else if ( i4.OriginalName == "span" && i4.GetAttributeValue( "class", "" ) == "mark_adult" ) // 19금 마크가 있으면 미성년자 관람 불가 웹툰
														{
															// 으허어허어헝ㅎ 안댕 19금이라니
															data.adultWebtoon = true;
														}
													}
												}
												else if ( i3.OriginalName == "ul" && i3.GetAttributeValue( "class", "" ) == "resultListItem" )
												{
													int emCount = 0; // em 태그가 여러개 이므로 데이터의 형태를 알기위해 선언

													foreach ( HtmlNode i4 in i3.ChildNodes )
													{
														if ( i4.OriginalName == "li" )
														{
															foreach ( HtmlNode i5 in i4.ChildNodes )
															{
																if ( i5.OriginalName == "em" )
																{
																	switch ( emCount )
																	{
																		case 0:
																			data.author = i5.InnerText.Trim( );
																			break;
																		case 1:
																			data.genre = i5.InnerText;
																			break;
																		case 2:
																			data.num = int.Parse( i5.InnerText.Replace( "회", "" ) );
																			break;
																		case 3:
																			data.uploadDate = i5.InnerText;
																			break;
																	}

																	emCount++;
																}
															}
														}
													}
												}
											}

											if ( data.type != "" )
											{
												WebtoonSearchResultDetail detailResult = Webtoon.SearchDetailRequest( data.url ); // 썸네일 이미지와 설명을 가져옴

												data.thumbnailURL = detailResult.thumbnailURL;
												data.description = detailResult.description;

												result.Add( data );
											}
										}
									}
								}
							}

							return result;
						}
					}
				}
			}
			catch ( WebException ex )
			{
				if ( ex.Response == null )
				{
					Utility.WriteErrorLog( ex.Message, "WebException" );
					ErrorMessageCall.Invoke( "귀하의 인터넷 연결을 확인하세요." );
				}
				else
				{
					Utility.WriteErrorLog( ex.Message, "WebException" );
					ErrorMessageCall.Invoke( "서버에서 오류가 발생했습니다, " + ex.Response + " 오류 코드를 반환했습니다." );
				}
			}
			catch ( ThreadAbortException )
			{
				GC.Collect( 0, GCCollectionMode.Forced ); // 쓰레드가 강제 종료된 후 메모리를 정리하기 위해 GC 강제 실행
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, "Exception" );
				ErrorMessageCall.Invoke( "알 수 없는 오류가 발생했습니다, 로그 파일을 참고하세요." );
			}

			return result;
		}

		public static List<WebtoonSearchResult> SearchTitle( string searchString )
		{
			string url = "http://comic.naver.com/search.nhn?m=webtoon&keyword=" + HttpUtility.UrlEncode( searchString ) + "&type=title";
			int maxPage = Webtoon.SearchMaxPage( url );

			List<WebtoonSearchResult> resultPages = new List<WebtoonSearchResult>( );

			for ( int i = 1; i <= maxPage; i++ )
			{
				List<WebtoonSearchResult> result = Webtoon.InternalSearch( url + "&page=" + i );

				resultPages = resultPages.Concat( result ).ToList( );
			}

			return resultPages;
		}

		// 해당 웹툰의 최대 리스트 페이지를 반환.
		public static int GetListMaxPage( string url )
		{
			try
			{
				System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo( "en-US" );

				url += "&page=999999999"; // 999999999 로 요청할 시 가장 뒤에 페이지로 이동

				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( url );
				request.Method = "GET";

				using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
				{
					using ( Stream responseStream = response.GetResponseStream( ) )
					{
						using ( StreamReader reader = new StreamReader( responseStream, Encoding.UTF8 ) )
						{
							string htmlResult = reader.ReadToEnd( );

							HtmlDocument document = new HtmlDocument( );
							document.LoadHtml( htmlResult );

							foreach ( HtmlNode i in document.DocumentNode.SelectNodes( "//strong" ) )
							{
								if ( i.GetAttributeValue( "class", "" ) == "page" )
								{
									foreach ( HtmlNode node2 in i.ChildNodes )
									{
										if ( node2.OriginalName == "em" && node2.GetAttributeValue( "class", "" ) == "num_page" )
										{
											return int.Parse( node2.InnerText );
										}
									}
								}
							}
						}
					}
				}
			}
			catch ( WebException ex )
			{
				if ( ex.Response == null )
				{
					Utility.WriteErrorLog( ex.Message, "WebException" );
					ErrorMessageCall.Invoke( "귀하의 인터넷 연결을 확인하세요." );
				}
				else
				{
					Utility.WriteErrorLog( ex.Message, "WebException" );
					ErrorMessageCall.Invoke( "서버에서 오류가 발생했습니다, " + ex.Response + " 오류 코드를 반환했습니다." );
				}
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, "Exception" );
				ErrorMessageCall.Invoke( "알 수 없는 오류가 발생했습니다, 로그 파일을 참고하세요." );
			}

			return -1;
		}

		private static List<WebtoonPageInformation> GetTargetPageInformations( string targetPageURL )
		{
			List<WebtoonPageInformation> pages = new List<WebtoonPageInformation>( );

			try
			{
				System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo( "en-US" );

				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( targetPageURL );
				request.Method = "GET";

				using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
				{
					using ( Stream responseStream = response.GetResponseStream( ) )
					{
						using ( StreamReader reader = new StreamReader( responseStream, Encoding.UTF8 ) )
						{
							string htmlResult = reader.ReadToEnd( );

							HtmlDocument document = new HtmlDocument( );
							document.LoadHtml( htmlResult );

							int i = 0; // 현재 리스트의 for문 위치를 체크하기 위함

							foreach ( HtmlNode node in document.DocumentNode.SelectNodes( "//tr" ) )
							{
								if ( node.ChildNodes.Count == 9 ) // 웹툰 리스트의 하위 노드 수는 항상 9개
								{
									foreach ( HtmlNode node2 in node.ChildNodes )
									{
										WebtoonPageInformation info = new WebtoonPageInformation( );

										if ( node2.OriginalName == "td" )
										{
											// 업로드 날짜 정보 찾기
											int tdNodeI = 0;
											foreach ( HtmlNode node3 in document.DocumentNode.SelectNodes( "//td" ) )
											{
												if ( node3.GetAttributeValue( "class", "" ) == "num" )
												{
													if ( tdNodeI == i )
													{
														info.uploadDate = node3.InnerText;
													}

													tdNodeI++;
												}
											}

											// 별점 정보 찾기
											int nodeI = 0; // td 하위 노드의 div 개수를 체크하기 위함

											foreach ( HtmlNode node3 in document.DocumentNode.SelectNodes( "//div" ) )
											{
												if ( node3.GetAttributeValue( "class", "" ) == "rating_type" )
												{
													if ( nodeI == i )
													{
														int node2I = 0; // div 하위 노드의 strong 개수를 체크하기 위함

														foreach ( HtmlNode node4 in node3.SelectNodes( "//strong" ) )
														{
															if ( node2I == i ) // 현재 strong for 문 i와 현재 리스트의 i가 같으면 그것이 해당 웹툰 화의 별점 정보
															{
																info.starRate = node4.InnerText;

																break;
															}

															node2I++;
														}
													}

													nodeI++;
												}
											}

											// 기타 데이터 찾기
											foreach ( HtmlNode node3 in node2.ChildNodes )
											{
												if ( node3.OriginalName == "a" )
												{
													if ( node3.GetAttributeValue( "href", "" ).StartsWith( "/webtoon/detail.nhn?" ) ) // /webtoon/detail.nhn? 로 시작하는 링크가 해당 웹툰 화 정보의 상위 노드
													{
														foreach ( HtmlNode node4 in node3.ChildNodes )
														{
															if ( node4.OriginalName == "img" )
															{
																info.title = HttpUtility.HtmlDecode( node4.GetAttributeValue( "title", "" ).Trim( ) );
																info.url = node3.GetAttributeValue( "href", "" );

																// 예시 : http://comic.naver.com/webtoon/detail.nhn?titleId=570503&no=151&weekday=thu 이면 no=151 쿼리 정보에서 151이 해당 화의 i임
																info.num = int.Parse( HttpUtility.ParseQueryString( ( new Uri( "http://comic.naver.com" + info.url ) ).Query ).Get( "no" ) );
																info.thumbnailURL = node4.GetAttributeValue( "src", "" );

																break;
															}
														}
													}
												}
											}

											pages.Add( info );
											i++;

											break;
										}
									}
								}
							}
						}
					}
				}
			}
			catch ( WebException ex )
			{
				if ( ex.Response == null )
				{
					Utility.WriteErrorLog( ex.Message, "WebException" );
					ErrorMessageCall.Invoke( "귀하의 인터넷 연결을 확인하세요." );
				}
				else
				{
					Utility.WriteErrorLog( ex.Message, "WebException" );
					ErrorMessageCall.Invoke( "서버에서 오류가 발생했습니다, " + ex.Response + " 오류 코드를 반환했습니다." );
				}
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, "Exception" );
				ErrorMessageCall.Invoke( "알 수 없는 오류가 발생했습니다, 로그 파일을 참고하세요." );
			}

			return pages;
		}

		private static void ThumbnailImageDownload( string directory, string directURL )
		{
			HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( directURL );
			request.Method = "GET";
			request.KeepAlive = true;
			request.Referer = "http://comic.naver.com";
			request.Accept = "image/webp,image/*,*/*;q=0.8";
			request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";

			using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
			{
				using ( Stream stReadData = response.GetResponseStream( ) )
				{
					using ( MemoryStream ms = new MemoryStream( ) )
					{
						stReadData.CopyTo( ms );

						File.WriteAllBytes( directory + @"\썸네일.jpg", ms.ToArray( ) );
					}
				}
			}
		}

		private static byte[ ] ThumbnailImageToByteArray( string directURL )
		{
			HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( directURL );
			request.Method = "GET";
			request.KeepAlive = true;
			request.Referer = "http://comic.naver.com";
			request.Accept = "image/webp,image/*,*/*;q=0.8";
			request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";

			using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
			{
				using ( Stream stReadData = response.GetResponseStream( ) )
				{
					return Utility.StreamToByteArray( stReadData );
				}
			}
		}

		private static void ImageDownload( string directory, string directURL, int count )
		{
			HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( directURL );
			request.Method = "GET";
			request.KeepAlive = true;
			request.Referer = "http://comic.naver.com";
			request.Accept = "image/webp,image/*,*/*;q=0.8";
			request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";

			using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
			{
				using ( Stream stReadData = response.GetResponseStream( ) )
				{
					using ( MemoryStream ms = new MemoryStream( ) )
					{
						stReadData.CopyTo( ms );

						File.WriteAllBytes( directory + @"\image_" + count + ".jpg", ms.ToArray( ) );
					}
				}
			}
		}
		
		private static byte[ ] ImageToByteArray( string directURL )
		{
			HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( directURL );
			request.Method = "GET";
			request.KeepAlive = true;
			request.Referer = "http://comic.naver.com";
			request.Accept = "image/webp,image/*,*/*;q=0.8";
			request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";

			using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
			{
				using ( Stream stReadData = response.GetResponseStream( ) )
				{
					return Utility.StreamToByteArray( stReadData );
				}
			}
		}

		private static bool IsAdultBlocked( string htmlString )
		{
			// https://nid.naver.com/nidlogin.login // 가 네이버 로그인 창 ( 즉 성인 인증 주소 )
			return htmlString.IndexOf( "https://nid.naver.com/nidlogin.login" ) > 0;
		}

		public static bool IsAdultWebtoon( string htmlString )
		{
			//var isAdultWebtoon = 'N'; // html 내에 자바스크립트에 설정되는 변수 (N - 미성년자 관람 가능, Y - 관람 불가능)
			return htmlString.IndexOf( "var isAdultWebtoon = 'Y'" ) > 0;
		}

		private static void DownloadImagesTargetURLDataMode( WebtoonPageInformation info )
		{
			DownloadProgressChanged.Invoke( 0 );

			string thisDir = Webtoon.BaseDirectory;

			StatusMessageLabelSet.Invoke( "다운로드 준비 중 ..." );

			byte[ ] thumbnailImageByteArray = Webtoon.ThumbnailImageToByteArray( info.thumbnailURL );

			List<string> webtoonImages = new List<string>( );
			List<byte[ ]> webtoonImagesByteArray = new List<byte[]>( );

			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "http://comic.naver.com" + info.url );
				request.Method = "GET";

				// 인증
				//request.CookieContainer = new CookieContainer( );
				//foreach ( CookieStruct i in rr )
				//{
				//	request.CookieContainer.Add( new Cookie( i.id, i.value, "/", request.Host ) );
				//}

				using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
				{
					using ( Stream responseStream = response.GetResponseStream( ) )
					{
						using ( StreamReader reader = new StreamReader( responseStream, Encoding.UTF8 ) )
						{
							string htmlResult = reader.ReadToEnd( );

							HtmlDocument document = new HtmlDocument( );
							document.LoadHtml( htmlResult );

							if ( request.Address.GetLeftPart( UriPartial.Path ) == "https://nid.naver.com/nidlogin.login" )
							{
								StatusMessageLabelSet.Invoke( "액세스가 거부되었습니다, 다운로드 할 수 없습니다." );
								DownloadProgressChanged.Invoke( 0 );

								return;
							}

							foreach ( HtmlNode node in document.DocumentNode.SelectNodes( "//img" ) )
							{
								if ( node.GetAttributeValue( "src", "" ).StartsWith( "http://imgcomic.naver.net/webtoon/" ) )
								{
									webtoonImages.Add( node.GetAttributeValue( "src", "" ) );
								}
							}

							int i = 0;

							foreach ( string url in webtoonImages )
							{
								i++;

								StatusMessageLabelSet.Invoke( "다운로드 중 ... " + ( int ) ( ( ( float ) i / ( float ) webtoonImages.Count ) * 100 ) + "%" );
								DownloadProgressChanged.Invoke( ( ( float ) i / ( float ) webtoonImages.Count ) );

								byte[ ] data = Webtoon.ImageToByteArray( url );

								webtoonImagesByteArray.Add( data );

								if ( !Webtoon.FastDownloadMode )
									Thread.Sleep( 30 );
							}

							if ( Webtoon.CurrentBaseInformation.HasValue )
							{
								ProgramViewer.CreateDataFile( thisDir,
									info.num + " - " + Utility.StripFolderName( info.title ),
									Webtoon.CurrentBaseInformation.Value.title,
									info.title,
									info.starRate,
									info.uploadDate,
									thumbnailImageByteArray,
									webtoonImagesByteArray
								);
							}

							//switch ( Viewer.Create( thisDir, info ) )
							//{
							//	case Viewer.ViewerCreateResult.DirectoryNotFoundException:
							//		ErrorMessageCall.Invoke( info.title + " - 웹툰 뷰어 파일을 생성할 수 없습니다, 저장 폴더를 찾을 수 없습니다." );
							//		break;
							//	case Viewer.ViewerCreateResult.IOException:
							//		ErrorMessageCall.Invoke( info.title + " - 웹툰 뷰어 파일을 생성할 수 없습니다, 파일 처리를 할 수 없었습니다." );
							//		break;
							//	case Viewer.ViewerCreateResult.UnauthorizedAccessException:
							//		ErrorMessageCall.Invoke( info.title + " - 웹툰 뷰어 파일을 생성할 수 없습니다, 액세스가 거부되었습니다." );
							//		break;
							//	case Viewer.ViewerCreateResult.Unknown:
							//		ErrorMessageCall.Invoke( info.title + " - 웹툰 뷰어 파일을 생성할 수 없습니다, 알 수 없는 오류가 발생했습니다, 로그 파일을 참고하세요." );
							//		break;
							//	case Viewer.ViewerCreateResult.Success:
							//		// 뷰어 생성 성공
							//		break;
							//}
						}
					}
				}
			}
			catch ( WebException ex )
			{
				Utility.WriteErrorLog( ex.Message, "WebException" );
				ErrorMessageCall.Invoke( "웹 오류가 발생했습니다." );
			}
			catch ( ThreadAbortException )
			{
				GC.Collect( 0, GCCollectionMode.Forced ); // 쓰레드가 강제 종료된 후 메모리를 정리하기 위해 GC 강제 실행
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, "Exception" );
				ErrorMessageCall.Invoke( "알 수 없는 오류가 발생했습니다, 로그 파일을 참고하세요." );
			}
		}

		private static async void DownloadImagesTargetURL( WebtoonPageInformation info )
		{
			// 오류
			// 연애혁명 - 130. said, sad <남유리> 에피소드에서 'ArgumentException : 경로에 잘못된 문자가 있습니다' 예외가 발생
			// < > 는 폴더 이름으로 사용할 수 없음.

			// 폴더 이름으로 사용할 수 없는 문자를 제거합니다.
			DownloadProgressChanged.Invoke( 0 );

			info.title = Utility.StripFolderName( info.title );

			string thisDir = Webtoon.BaseDirectory + "\\" + info.num + " - " + info.title;

			StatusMessageLabelSet.Invoke( "다운로드 준비 중 ..." );

			Directory.CreateDirectory( thisDir + "\\이미지" );

			Webtoon.ThumbnailImageDownload( thisDir, info.thumbnailURL );

			List<string> webtoonImages = new List<string>( );

			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "http://comic.naver.com" + info.url );
				request.Method = "GET";

				// 인증
				//request.CookieContainer = new CookieContainer( );
				//foreach ( CookieStruct i in rr )
				//{
				//	request.CookieContainer.Add( new Cookie( i.id, i.value, "/", request.Host ) );
				//}

				using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
				{
					using ( Stream responseStream = response.GetResponseStream( ) )
					{
						using ( StreamReader reader = new StreamReader( responseStream, Encoding.UTF8 ) )
						{
							string htmlResult = reader.ReadToEnd( );

							HtmlDocument document = new HtmlDocument( );
							document.LoadHtml( htmlResult );

							if ( request.Address.GetLeftPart( UriPartial.Path ) == "https://nid.naver.com/nidlogin.login" )
							{
								StatusMessageLabelSet.Invoke( "액세스가 거부되었습니다, 다운로드 할 수 없습니다." );
								DownloadProgressChanged.Invoke( 0 );

								return;
							}

							foreach ( HtmlNode node in document.DocumentNode.SelectNodes( "//img" ) )
							{
								if ( node.GetAttributeValue( "src", "" ).StartsWith( "http://imgcomic.naver.net/webtoon/" ) )
								{
									webtoonImages.Add( node.GetAttributeValue( "src", "" ) );
								}
							}

							int i = 0;

							foreach ( string url in webtoonImages )
							{
								i++;

								StatusMessageLabelSet.Invoke( "다운로드 중 ... " + ( int ) ( ( ( float ) i / ( float ) webtoonImages.Count ) * 100 ) + "%" );
								DownloadProgressChanged.Invoke( ( ( float ) i / ( float ) webtoonImages.Count ) );

								Webtoon.ImageDownload( thisDir + "\\이미지", url, i );

								if ( !Webtoon.FastDownloadMode )
									Thread.Sleep( 30 );
							}

							await Task.Run( new Action( delegate ( )
							{
								ImageMerge.Merge( thisDir );
							} ) );

							switch ( Viewer.Create( thisDir, info ) )
							{
								case Viewer.ViewerCreateResult.DirectoryNotFoundException:
									ErrorMessageCall.Invoke( info.title + " - 웹툰 뷰어 파일을 생성할 수 없습니다, 저장 폴더를 찾을 수 없습니다." );
									break;
								case Viewer.ViewerCreateResult.IOException:
									ErrorMessageCall.Invoke( info.title + " - 웹툰 뷰어 파일을 생성할 수 없습니다, 파일 처리를 할 수 없었습니다." );
									break;
								case Viewer.ViewerCreateResult.UnauthorizedAccessException:
									ErrorMessageCall.Invoke( info.title + " - 웹툰 뷰어 파일을 생성할 수 없습니다, 액세스가 거부되었습니다." );
									break;
								case Viewer.ViewerCreateResult.Unknown:
									ErrorMessageCall.Invoke( info.title + " - 웹툰 뷰어 파일을 생성할 수 없습니다, 알 수 없는 오류가 발생했습니다, 로그 파일을 참고하세요." );
									break;
								case Viewer.ViewerCreateResult.Success:
									// 뷰어 생성 성공
									break;
							}
						}
					}
				}
			}
			catch ( WebException ex )
			{
				Utility.WriteErrorLog( ex.Message, "WebException" );
				ErrorMessageCall.Invoke( "웹 오류가 발생했습니다." );
			}
			catch ( ThreadAbortException )
			{
				GC.Collect( 0, GCCollectionMode.Forced ); // 쓰레드가 강제 종료된 후 메모리를 정리하기 위해 GC 강제 실행
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, "Exception" );
				ErrorMessageCall.Invoke( "알 수 없는 오류가 발생했습니다, 로그 파일을 참고하세요." );
			}
		}

		public static async Task<WebtoonBasicInformation> GetBasicInformation( string url )
		{
			if ( Webtoon.IsValidFixURL( ref url ) )
			{
				int maxPage = Webtoon.GetListMaxPage( url );

				if ( maxPage != -1 )
				{
					WebtoonBasicInformation result = await Task.Run<WebtoonBasicInformation>( new Func<WebtoonBasicInformation>( delegate ( )
					{
						WebtoonBasicInformation returnInfo = new WebtoonBasicInformation( );
						returnInfo.url = url;

						try
						{
							HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( url );
							request.Method = "GET";

							// 인증
							//request.CookieContainer = new CookieContainer( );
							//foreach ( CookieStruct i in rr )
							//{
							//	request.CookieContainer.Add( new Cookie( i.id, i.value, "/", request.Host ) );
							//}

							using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
							{
								using ( Stream responseStream = response.GetResponseStream( ) )
								{
									using ( StreamReader reader = new StreamReader( responseStream, Encoding.UTF8 ) )
									{
										string htmlResult = reader.ReadToEnd( );

										HtmlDocument document = new HtmlDocument( );
										document.LoadHtml( htmlResult );

										if ( Webtoon.IsAdultWebtoon( htmlResult ) )
										{
											ErrorMessageCall.Invoke( "현재 프로그램 버전에서는 미성년자 관람 불가 웹툰을 다운받으실 수 없습니다." );
											return new WebtoonBasicInformation( ) { errorChecked = true };
										}

										StatusMessageLabelSet.Invoke( "기본 정보 불러오는 중 ..." );

										//	특정 웹툰의 설명을 못 가져오는 이유
										//
										//	"이거 나만 그런거 아니지?"
										//	응, 너만 그런거 아니야.
										//	반박불가 공감이 밀려온다.
										//
										//	이러한 설명이 있다고 가정을 하면
										//	HTML 코드의 설명 meta 부분의 정의는
										//	<meta property="og:description" content=""이거 나만 그런거 아니지?"
										//	응, 너만 그런거 아니야.\n반박불가 공감이 밀려온다.">
										//	로 정의된다 하지만 node.GetAttributeValue( "content", "" ) 메소드를 사용하여
										//	content 프로퍼티의 값을 가져오려하면 웹툰 설명에 " 로 시작을 하기 때문에
										//	공백으로 지정된 채 값을 가져오게 됨.

										int descStart = htmlResult.IndexOf( "meta property=\"og:description\"" );

										string[ ] trashDatas = htmlResult.Substring( descStart, htmlResult.IndexOf( ">", descStart ) - descStart )
											.Split( new char[ 1 ] { '"' }, StringSplitOptions.RemoveEmptyEntries );

										string desc = "";

										try
										{
											for ( int i = 3; i < trashDatas.Length; i++ )
											{
												desc += trashDatas[ i ] + Environment.NewLine;
											}
										}
										catch ( IndexOutOfRangeException ) { }

										returnInfo.description = HttpUtility.HtmlDecode( desc.Trim( ) );

										foreach ( HtmlNode node in document.DocumentNode.SelectNodes( "//meta" ) )
										{
											switch ( node.GetAttributeValue( "property", "" ) )
											{
												case "og:title": // 해당 웹툰 이름
													returnInfo.title = node.GetAttributeValue( "content", "" ).Trim( );
													break;
												//case "og:description": // 해당 웹툰 설명 
												//	returnInfo.description = node.GetAttributeValue( "content", "" ).Trim( ); // 일부 웹툰에서 버그가 발생
												//	break;
												case "og:image": // 해당 웹툰 썸네일 이미지
													returnInfo.thumbnailURL = node.GetAttributeValue( "content", "" ).Trim( );
													break;
											}
										}

										List<WebtoonPageInformation> pages = new List<WebtoonPageInformation>( );

										for ( int i = 1; i <= maxPage; i++ )
										{
											List<WebtoonPageInformation> informations = Webtoon.GetTargetPageInformations( url + "&page=" + i );

											pages = pages.Concat( informations ).ToList( );

											StatusMessageLabelSet.Invoke( "페이지 정보 불러오는 중 ... " + ( int ) ( ( ( float ) i / ( float ) maxPage ) * 100 ) + "%" );

											Thread.Sleep( 100 );
										}

										returnInfo.totalNum = pages.Count;
										returnInfo.pages = pages;
									}
								}
							}
						}
						catch ( WebException ex )
						{
							if ( ex.Response == null )
							{
								Utility.WriteErrorLog( ex.Message, "WebException" );
								ErrorMessageCall.Invoke( "귀하의 인터넷 연결을 확인하세요." );
								return new WebtoonBasicInformation( ) { errorChecked = true };
							}
							else
							{
								Utility.WriteErrorLog( ex.Message, "WebException" );
								ErrorMessageCall.Invoke( "서버에서 오류가 발생했습니다, " + ex.Response + " 오류 코드를 반환했습니다." );
								return new WebtoonBasicInformation( ) { errorChecked = true };
							}
						}
						catch ( Exception ex )
						{
							Utility.WriteErrorLog( ex.Message, "Exception" );
							ErrorMessageCall.Invoke( "알 수 없는 오류가 발생했습니다, 로그 파일을 참고하세요." );
							return new WebtoonBasicInformation( ) { errorChecked = true };
						}

						Webtoon.CurrentBaseInformation = returnInfo;

						return returnInfo;
					} ) );

					await Task.Delay( 500 );

					return result;
				}
				else
				{
					ErrorMessageCall.Invoke( "입력한 웹툰 링크가 올바르지 않습니다, 올바른 링크를 입력하세요." );
					return new WebtoonBasicInformation( ) { errorChecked = true };
				}
			}
			else
			{
				ErrorMessageCall.Invoke( "입력한 웹툰 링크가 올바르지 않습니다, 올바른 링크를 입력하세요." );
				return new WebtoonBasicInformation( ) { errorChecked = true };
			}
		}

		public static void Request( string url )
		{
			DownloadThread = new Thread( ( ) =>
			{
				try
				{
					System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo( "en-US" );

					if ( Webtoon.IsValidFixURL( ref url ) )
					{
						int maxPage = Webtoon.GetListMaxPage( url );

						if ( maxPage != -1 )
						{
							List<WebtoonPageInformation> pages = new List<WebtoonPageInformation>( );

							for ( int i = 1; i <= maxPage; i++ )
							{
								List<WebtoonPageInformation> informations = Webtoon.GetTargetPageInformations( url + "&page=" + i );

								pages = pages.Concat( informations ).ToList( );

								StatusMessageLabelSet.Invoke( "기본 정보 불러오는 중 ... " + ( int ) ( ( ( float ) i / ( float ) maxPage ) * 100 ) + "%" );

								Thread.Sleep( 100 );
							}

							StatusMessageLabelSet.Invoke( "다운로드 준비 중 ..." );

							foreach ( WebtoonPageInformation info in pages )
							{
								if ( Webtoon.DownloadBlockList.Contains( info.num ) )
								{
									continue;
								}

								DownloadTargetChanged.Invoke( info );

								if ( Webtoon.OnlyDataMode )
									Webtoon.DownloadImagesTargetURLDataMode( info );
								else
									Webtoon.DownloadImagesTargetURL( info );

								if ( !Webtoon.FastDownloadMode )
									Thread.Sleep( 400 );
							}

							DownloadFinished.Invoke( true );
						}
						else
						{
							DownloadFinished.Invoke( false );
							ErrorMessageCall.Invoke( "입력한 웹툰 링크가 올바르지 않습니다, 올바른 링크를 입력하세요." );
						}
					}
					else
					{
						DownloadFinished.Invoke( false );
						ErrorMessageCall.Invoke( "입력한 웹툰 링크가 올바르지 않습니다, 올바른 링크를 입력하세요." );
					}
				}
				catch ( ThreadAbortException )
				{
					GC.Collect( 0, GCCollectionMode.Forced ); // 쓰레드가 강제 종료된 후 메모리를 정리하기 위해 GC 강제 실행
				}
				catch ( Exception ex )
				{
					Utility.WriteErrorLog( ex.Message, "Exception" );
					ErrorMessageCall.Invoke( "알 수 없는 오류가 발생했습니다, 로그 파일을 참고하세요." );
				}
			} )
			{
				IsBackground = true
			};

			DownloadThread.Start( );
		}
	}
}
