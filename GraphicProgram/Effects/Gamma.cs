using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicProgram
{
    public static class Gamma
    {
        public static Bitmap setGamma(Bitmap image, int value)
        {
            var gamma = value * 0.04f;
            Bitmap bitmap = new Bitmap(image.Width, image.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            ImageAttributes imageAttributes = new ImageAttributes();

            imageAttributes.SetGamma(gamma);

            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();
            imageAttributes.Dispose();

            return bitmap;
        }
    }
}
