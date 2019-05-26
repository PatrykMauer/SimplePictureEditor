using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicProgram.Effects
{
    public static class Histogram
    {
        public static void seeHistogramTxt(Bitmap bitmap)
        {
            // Get your image in a bitmap; this is how to get it from a picturebox
            // Store the histogram in a dictionary          
            Dictionary<Color, int> histo = new Dictionary<Color, int>();
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    // Get pixel color 
                    Color c = bitmap.GetPixel(x, y);
                    // If it exists in our 'histogram' increment the corresponding value, or add new
                    if (histo.ContainsKey(c))
                        histo[c] = histo[c] + 1;
                    else
                        histo.Add(c, 1);
                }
            }
            // This outputs the histogram in an output window
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            var path = System.IO.Path.GetTempPath();
            using (StreamWriter streamWriter = new StreamWriter(path + "histogram.txt"))
            {
                foreach (Color key in histo.Keys)
                {
                    streamWriter.WriteLine(key.ToString() + ": " + histo[key]);
                }
            }
            System.Diagnostics.Process.Start(path + "histogram.txt");
        }
        public static Bitmap seeHistogramJpg(Bitmap bitmap)
        {
            int[] histogram_r = new int[256];
            float max = 0;

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    int redValue = bitmap.GetPixel(i, j).R;
                    histogram_r[redValue]++;
                    if (max < histogram_r[redValue])
                        max = histogram_r[redValue];
                }
            }

            int histHeight = 128;
            Bitmap img = new Bitmap(256, histHeight + 10);
            using (Graphics g = Graphics.FromImage(img))
            {
                for (int i = 0; i < histogram_r.Length; i++)
                {
                    float pct = histogram_r[i] / max;   // What percentage of the max is this value?
                    g.DrawLine(Pens.Black,
                        new Point(i, img.Height - 5),
                        new Point(i, img.Height - 5 - (int)(pct * histHeight))  // Use that percentage of the height
                        );
                }
            }
            return img;
        }
    }
}
