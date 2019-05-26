using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicProgram
{
    public static class Emboss
    {
        public static Bitmap detectEmboss(Bitmap image)
        {
            Bitmap newBitmap = new Bitmap(image.Width, image.Height);
            int LastColumn = 0;
            for (int x = 1; x <= image.Width - 1; x++)
            {
                for (int y = 1; y <= image.Height - 1; y++)
                {
                    newBitmap.SetPixel(x, y, Color.DarkGray);
                }

            }
                for (int x = 1; x <= image.Width - 1; x++)
                {
                    for (int y = 1; y <= image.Height - 1; y++)
                    {
                        try
                        {
                            Color pixel = image.GetPixel(x, y);

                            int colVal = (pixel.R + pixel.G + pixel.B);

                            if (LastColumn == 0) LastColumn = (pixel.R + pixel.G + pixel.B);

                            int diff;

                            if (colVal > LastColumn) { diff = colVal - LastColumn; } else { diff = LastColumn - colVal; }

                            if (diff > 100)
                            {
                                newBitmap.SetPixel(x, y, Color.Gray);
                            LastColumn = colVal;
                            }


                        }
                        catch (Exception) { }
                    }
                }

                for (int y = 1; y <= image.Height - 1; y++)
                {

                    for (int x = 1; x <= image.Width - 1; x++)
                    {
                        try
                        {
                            Color pixel = image.GetPixel(x, y);

                            int colVal = (pixel.R + pixel.G + pixel.B);

                            if (LastColumn == 0) LastColumn = (pixel.R + pixel.G + pixel.B);

                            int diff;

                            if (colVal > LastColumn) { diff = colVal - LastColumn; } else { diff = LastColumn - colVal; }

                            if (diff > 100)
                            {
                                newBitmap.SetPixel(x, y, Color.Gray);
                            LastColumn = colVal;
                            }

                        }
                        catch (Exception) { }
                    }

                }

                return newBitmap;
        }
    }
}