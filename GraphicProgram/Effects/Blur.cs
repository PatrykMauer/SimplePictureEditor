using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicProgram
{
    public static class Blur
    {
        public static Bitmap setBlur(Bitmap image, int value)
        {
            Bitmap bitmap = image as Bitmap;
            for (int x = value; x <= bitmap.Width - value; x++)
            {
                for (int y = value; y <= bitmap.Height - value; y++)
                {
                    try
                    {


                        Color prevX = bitmap.GetPixel(x - value, y);
                        Color nextX = bitmap.GetPixel(x + value, y);
                        Color prevY = bitmap.GetPixel(x, y - value);
                        Color nextY = bitmap.GetPixel(x, y + value);

                        int avgR = (int)((prevX.R + nextX.R + prevY.R + nextY.R) / 4);
                        int avgG = (int)((prevX.G + nextX.G + prevY.G + nextY.G) / 4);
                        int avgB = (int)((prevX.B + nextX.B + prevY.B + nextY.B) / 4);

                        bitmap.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                    }
                    catch (Exception) { }
                }
            }
            return bitmap;
        }
    }
}
