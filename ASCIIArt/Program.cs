using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ASCIIArt
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            InitializeSettings();
            IArtBuilder builder = new ASCIIBuilder();
            builder.ConvertToArtType(builder.Decolorization(builder.ResizeImage(LoadImage())));
            Console.Read();
        }
        static void InitializeSettings()
        {
            Console.SetWindowPosition(0, 0);
            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;
            Console.WriteLine("Select the image");
        }
        static Bitmap LoadImage()
        {
            OpenFileDialog openFileDialogImage = new OpenFileDialog();
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                Image photo = Image.FromFile(openFileDialogImage.FileName);
                Bitmap bmpImage = new Bitmap(photo);
                return bmpImage;
            }
            else{
                return null;
            }
        }
    }
}
