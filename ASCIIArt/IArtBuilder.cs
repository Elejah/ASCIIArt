using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIArt
{
    interface IArtBuilder
    {
        byte[,] Decolorization(Bitmap bitmap);
        Bitmap ResizeImage(Bitmap bitmap,int width =40,int height = 40, InterpolationMode mode = InterpolationMode.Bilinear);
        void ConvertToArtType(byte[,] image); 
    }
}
