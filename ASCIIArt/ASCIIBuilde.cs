using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIArt
{
    class ASCIIBuilder : IArtBuilder
    {
        public void ConvertToArtType(byte[,] image)
        {
            for (int i = 0; i < image.GetLength(0); i++)
            {
                string s = "";
                for (int j = 0; j < image.GetLength(1); j++)
                {
                    if ((image[i, j] <= 255) && (image[i, j] >= 241))
                    {
                        s = s + "  ";
                    }
                    if ((image[i, j] <= 240) && (image[i, j] >= 231))
                    {
                        s = s + " .";
                    }
                    if ((image[i, j] <= 230) && (image[i, j] >= 221))
                    {
                        s = s + @" ,";
                    }
                    if ((image[i, j] <= 220) && (image[i, j] >= 201))
                    {
                        s = s + @" -";
                    }
                    if ((image[i, j] <= 200) && (image[i, j] >= 191))
                    {
                        s = s + " :";
                    }
                    if ((image[i, j] <= 190) && (image[i, j] >= 181))
                    {
                        s = s + " ;";
                    }
                    if ((image[i, j] <= 180) && (image[i, j] >= 171))
                    {
                        s = s + "--";
                    }
                    if ((image[i, j] <= 170) && (image[i, j] >= 161))
                    {
                        s = s + "::";
                    }
                    if ((image[i, j] <= 160) && (image[i, j] >= 151))
                    {
                        s = s + "%%";
                    }
                    if ((image[i, j] <= 150) && (image[i, j] >= 141))
                    {
                        s = s + "@@";
                    }
                    if ((image[i, j] <= 140) && (image[i, j] >= 131))
                    {
                        s = s + "SS";
                    }
                    if ((image[i, j] <= 130) && (image[i, j] >= 121))
                    {
                        s = s + "DD";
                    }
                    if ((image[i, j] <= 120) && (image[i, j] >= 101))
                    {
                        s = s + "OO";
                    }
                    if ((image[i, j] <= 100) && (image[i, j] >= 91))
                    {
                        s = s + "##";
                    }
                    if ((image[i, j] <= 90) && (image[i, j] >= 51))
                    {
                        s = s + "&&";
                    }
                    if ((image[i, j] <= 50) && (image[i, j] >= 0))
                    {
                        s = s + "$$";
                    }
                }
                Console.WriteLine(s);
            }
        }
        public byte[,] Decolorization(Bitmap bitmap)
        {
            byte[,] img = new byte[bitmap.Height, bitmap.Width];
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color pixelColor = bitmap.GetPixel(i, j);
                    img[j, i] = Convert.ToByte((pixelColor.A + pixelColor.B + pixelColor.G) / 3);
                }
            }
            return img;
        }

        public Bitmap ResizeImage(Bitmap bitmap, int width = 40, int height = 40, InterpolationMode mode = InterpolationMode.Bilinear)
        {
            var res = new Bitmap(width, height);
            using (var gr = Graphics.FromImage(res))
            {
                gr.InterpolationMode = mode;
                gr.DrawImage(bitmap, 0, 0, width, height);
            }

            return res;
        }
    }
}

