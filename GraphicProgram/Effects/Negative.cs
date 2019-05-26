using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GraphicProgram.Effects
{
    class Negative
    {
        public static Bitmap setNegativeSlow(Bitmap bitmap)
        {
          
          Color Color;
          for (int x = 0; x < bitmap.Height; x++)
              for (int y = 0; y < bitmap.Width; y++)
                 {
                 Color = bitmap.GetPixel(y,x);
                 Color = Color.FromArgb(255 - Color.R, 255 - Color.G, 255 - Color.B);
                 bitmap.SetPixel(y,x, Color);
                 }
            return bitmap;
        }

        public static Bitmap setNegativeFast(Bitmap bitmap)
        {
            
                BitmapData bitmapData = null;
                Rectangle area;
                IntPtr dataBegin;
                int numberOfBytes;
                byte[] RGBvalues;

                area = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                numberOfBytes = bitmap.Width * bitmap.Height * 3;
                RGBvalues = new byte[numberOfBytes];

                bitmapData = bitmap.LockBits(area, ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);

                dataBegin = bitmapData.Scan0;
                Marshal.Copy(dataBegin, RGBvalues, 0, numberOfBytes);

                for (int i = 0; i < RGBvalues.Length; i += 3)
                {
                    RGBvalues[i] = (byte)(255 - RGBvalues[i]);
                    RGBvalues[i + 1] = (byte)(255 - RGBvalues[i + 1]);
                    RGBvalues[i + 2] = (byte)(255 - RGBvalues[i + 2]);
                }
                Marshal.Copy(RGBvalues, 0, dataBegin, numberOfBytes);
                bitmap.UnlockBits(bitmapData);
                return bitmap;
        }
    }
}
