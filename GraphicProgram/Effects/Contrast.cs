using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicProgram
{
    public static class Contrast
    {
        public static Image SetContrast(Bitmap image,int value)
        {
            var contrast = value * 0.04f;
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            ImageAttributes imageAttributes = new ImageAttributes();
            
            ColorMatrix colorMatrix = new ColorMatrix(
                new float[][]
                {
                    new float[]{ contrast, 0f,0f,0f,0f},
                    new float[]{0f, contrast, 0f,0f,0f},
                    new float[]{0f,0f, contrast, 0f,0f},
                    new float[]{0f,0f,0f,1f,0f},
                    new float[]{0.001f, 0.001f, 0.001f, 0f,1f}
                });

            imageAttributes.SetColorMatrix(colorMatrix);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();
            imageAttributes.Dispose();
        
        return bmp;
    }
    }
}
