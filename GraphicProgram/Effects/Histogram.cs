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
        public static void seeHistogram(Bitmap bitmap)
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
    }
}
