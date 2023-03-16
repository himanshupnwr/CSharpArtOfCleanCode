using System;
using System.Drawing;

namespace CSharpArtOfCleanCode
{
    public class Names
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    //use f2 to use name change dialog in Resharper
    public class Example
    {
        public Bitmap GenerateImage(string path)
        {
            var bitmap = new Bitmap(path);
            var graphics = Graphics.FromImage(bitmap);
            graphics.DrawString("a", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 0));
            return bitmap;
        }
    }
}
