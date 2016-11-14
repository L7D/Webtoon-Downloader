using System;
using System.Drawing;
using System.IO;

namespace WebtoonDownloader.API
{
	static class ImageMerge
	{
		private static void InternalMerge( string dir, string[ ] targetFiles, int count )
		{
			int maxW = 0;
			int totalH = 0;

			foreach ( string i in targetFiles )
			{
				if ( !File.Exists( i ) ) continue;

				Image img = Image.FromFile( i );

				if ( img == null ) continue;

				totalH += img.Size.Height;

				if ( maxW < img.Size.Width )
				{
					maxW = img.Size.Width;
				}
			}

			Bitmap bmap = new Bitmap( maxW, totalH );
			Graphics g = Graphics.FromImage( bmap );

			int y = 0;
			foreach ( string i in targetFiles )
			{
				if ( !File.Exists( i ) ) continue;

				Image img = Image.FromFile( i );

				if ( img == null ) continue;

				g.DrawImage( img, 0, y );

				y += img.Size.Height;
			}

			bmap.Save( dir + @"\합체_" + count + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg );
		}

		public static void Merge( string dir )
		{
			// 오류 @_@
			// 이미지가 33개가 넘어가면 오류가 남. (정확하지 않음)
			string[ ] files = Directory.GetFiles( dir + @"\이미지\", "image_*.jpg" );

			Array.Sort( files, new Sort.NaturalStringComparer( ) );

			if ( files.Length > 10 ) // 10개 씩 이미지를 나누기 위해 파일 배열이 10개 이상인지 확인
			{
				int currentMergeCount = 0;
				int currentFileIndex = 0;
				int cycle = ( int ) ( files.Length / 10 );

				// @ 코드 설명 @
				// 해당 화의 이미지가 (files 배열의 개수가) 43개라고 가정하면
				// cycle 변수의 값은 43 / 10 = 4.3 = 4 가 됨
				// 남은 파일의 개수는 files.Length % 10 으로 확인한다
				// 0부터 4까지 총 5번을 '마지막 사이클 전까지' currentFileIndex를 +1 늘리면서
				// 중첩 for 문으로 10번씩을 돌린다
				// 이렇게 총 10 * 4 = 40 번을 돌리면
				// 총 40개의 이미지가 4개로 나뉘어져서 합쳐진다
				// 하지만 3개의 이미지가 남는다
				// 이 파일들은 마지막 사이클에서 (즉 5번째 루프 i=4) 합친다.

				for ( int i = 0; i <= cycle; i++ )
				{
					if ( i == cycle ) // 마지막 사이클인지 확인
					{
						if ( files.Length % 10 == 0 ) continue; // 남은 파일이 없으면 건너뛰기
						int remainFiles = files.Length % 10;

						// 남은 파일까지 전부 합친다.
						string[ ] tempFiles = new string[ remainFiles ];

						for ( int i2 = 0; i2 < remainFiles; i2++ )
						{
							tempFiles[ i2 ] = files[ currentFileIndex ];
							currentFileIndex++;
						}

						InternalMerge( dir, tempFiles, currentMergeCount );
						currentMergeCount++;
					}
					else
					{
						// 10개씩 나누면서 합친다.
						string[ ] tempFiles = new string[ 10 ];

						for ( int i2 = 0; i2 < 10; i2++ ) // 0 ~ 9
						{
							tempFiles[ i2 ] = files[ currentFileIndex ];
							currentFileIndex++;
						}

						InternalMerge( dir, tempFiles, currentMergeCount );
						currentMergeCount++;
					}
				}
			}
			else
			{
				int maxW = 0;
				int totalH = 0;

				foreach ( string i in files )
				{
					if ( !File.Exists( i ) ) continue;

					Image img = Image.FromFile( i );

					if ( img == null ) continue;

					totalH += img.Size.Height;

					if ( maxW < img.Size.Width )
					{
						maxW = img.Size.Width;
					}
				}

				Bitmap bmap = new Bitmap( maxW, totalH );
				Graphics g = Graphics.FromImage( bmap );

				int y = 0;
				foreach ( string i in files )
				{
					if ( !File.Exists( i ) ) continue;

					Image img = Image.FromFile( i );

					if ( img == null ) continue;

					g.DrawImage( img, 0, y );

					y += img.Size.Height;
				}

				bmap.Save( dir + @"\합체_0.jpg", System.Drawing.Imaging.ImageFormat.Jpeg );
			}
		}
	}
}
