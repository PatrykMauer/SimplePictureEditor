using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicProgram.Effects
{
    public static class grayScale
    {
        public static Bitmap setGrayScale(Bitmap bitmap)
        {
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color originalColor = bitmap.GetPixel(x, y);

                    int grayScale = (int)((originalColor.R * .3) + (originalColor.G * .59) + (originalColor.B * .11));

                    Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                    bitmap.SetPixel(x, y, newColor);
                }
            }
            return bitmap;
        }
    }
}
