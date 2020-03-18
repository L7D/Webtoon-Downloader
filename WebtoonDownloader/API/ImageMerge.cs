using System;
using System.Collections;
using System.Drawing;
using System.IO;

namespace WebtoonDownloader.API
{
    static class ImageMerge
    {

        public static void Save(String loc, ArrayList images, int maxW, int totalH)
        {
            using (Bitmap bmap = new Bitmap(maxW, totalH))
            {
                using (Graphics g = Graphics.FromImage(bmap))
                {
                    int y = 0;
                    foreach (string i in images)
                    {
                        if (!File.Exists(i)) continue;

                        Image img = Image.FromFile(i);

                        if (img == null) continue;

                        g.DrawImage(img, 0, y);

                        y += img.Size.Height;
                    }
                    bmap.Save(loc, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }


        }

        public static void Merge(string dir)
        {
            string[] files = Directory.GetFiles(dir + @"\이미지\", "image_*.jpg");

            Array.Sort(files, new Sort.NaturalStringComparer());

            int maxW = 0;
            int totalH = 0;

            ArrayList images = new ArrayList();
            int idx = 0;
            foreach (string i in files)
            {
                if (!File.Exists(i)) continue;

                Image img = Image.FromFile(i);

                if (img == null) continue;

                // 이미지 사이즈 제한..
                // https://stackoverflow.com/questions/29175585/what-is-the-maximum-resolution-of-c-sharp-net-bitmap
                if (totalH + img.Size.Height > 65535)
                {
                    Save(dir + @"\합체_" + idx++ + ".jpg", images, maxW, totalH);
                    images.Clear();
                    maxW = 0;
                    totalH = 0;
                }
                totalH += img.Size.Height;

                if (maxW < img.Size.Width)
                {
                    maxW = img.Size.Width;
                }


                images.Add(i);
            }
            if(images.Count > 0) Save(dir + @"\합체_" + idx++ + ".jpg", images, maxW, totalH);
        }
    }
}
