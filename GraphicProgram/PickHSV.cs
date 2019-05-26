using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static GraphicProgram.HsvToRgbConverter;
using static GraphicProgram.RgbToHsvConverter;


namespace GraphicProgram
{
    public static class PickHSV
    {
        public static Image Color (Image image){

            if (image != null)
            {
                BitmapData bmpData = null;
                Rectangle obszar;
                IntPtr dataBegin;
                int numberOfBytes;
                byte[] RGBvalues;
                Bitmap bmp = image as Bitmap;

                obszar = new Rectangle(0, 0, bmp.Width, bmp.Height);
                numberOfBytes = bmp.Width * bmp.Height * 3;
                RGBvalues = new byte[numberOfBytes];

                bmpData = bmp.LockBits(obszar, ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);

                dataBegin = bmpData.Scan0;
                Marshal.Copy(dataBegin, RGBvalues, 0, numberOfBytes);

                for (int i = 0; i < RGBvalues.Length; i += 3)
                {
                    var colorInRGB = new RGB(RGBvalues[i], RGBvalues[i + 1], RGBvalues[i + 2]);
                    var convertedRGBtoHSV = RgbToHsv(colorInRGB);
                    convertedRGBtoHSV.H = (convertedRGBtoHSV.H + 5f) % 360f;
                    convertedRGBtoHSV.S = convertedRGBtoHSV.S;
                    convertedRGBtoHSV.V = convertedRGBtoHSV.V;
                    var convertedHSVtoRGB = HsvToRgb(convertedRGBtoHSV);

                    RGBvalues[i] = (byte)(convertedHSVtoRGB.R);
                    RGBvalues[i + 1] = (byte)(convertedHSVtoRGB.G);
                    RGBvalues[i + 2] = (byte)(convertedHSVtoRGB.B);
                }
                Marshal.Copy(RGBvalues, 0, dataBegin, numberOfBytes);
                bmp.UnlockBits(bmpData);
                image = bmp;
                return image;
            }
            else
            {
                MessageBox.Show("Select an image first.");
                return null;
            }
        }


        public static Image Idk(Image image)
        {

            if (image != null)
            {
                BitmapData bmpData = null;
                Rectangle obszar;
                IntPtr dataBegin;
                int numberOfBytes;
                byte[] RGBvalues;
                Bitmap bmp = image as Bitmap;

                obszar = new Rectangle(0, 0, bmp.Width, bmp.Height);
                numberOfBytes = bmp.Width * bmp.Height * 3;
                RGBvalues = new byte[numberOfBytes];

                bmpData = bmp.LockBits(obszar, ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);

                dataBegin = bmpData.Scan0;
                Marshal.Copy(dataBegin, RGBvalues, 0, numberOfBytes);

                for (int i = 0; i < RGBvalues.Length; i += 3)
                {
                    var colorInRGB = new RGB(RGBvalues[i], RGBvalues[i + 1], RGBvalues[i + 2]);
                    var convertedRGBtoHSV = RgbToHsv(colorInRGB);
                    convertedRGBtoHSV.H = convertedRGBtoHSV.H;
                    convertedRGBtoHSV.S = (convertedRGBtoHSV.S + 0.05f) % 1f;
                    convertedRGBtoHSV.V = convertedRGBtoHSV.V;
                    var convertedHSVtoRGB = HsvToRgb(convertedRGBtoHSV);

                    RGBvalues[i] = (byte)(convertedHSVtoRGB.R);
                    RGBvalues[i + 1] = (byte)(convertedHSVtoRGB.G);
                    RGBvalues[i + 2] = (byte)(convertedHSVtoRGB.B);
                }
                Marshal.Copy(RGBvalues, 0, dataBegin, numberOfBytes);
                bmp.UnlockBits(bmpData);
                image = bmp;
                return image;
            }
            else
            {
                MessageBox.Show("Select an image first.");
                return null;
            }
        }



        public static Image Contrast(Image image)
        {

            if (image != null)
            {
                BitmapData bmpData = null;
                Rectangle obszar;
                IntPtr dataBegin;
                int numberOfBytes;
                byte[] RGBvalues;
                Bitmap bmp = image as Bitmap;

                obszar = new Rectangle(0, 0, bmp.Width, bmp.Height);
                numberOfBytes = bmp.Width * bmp.Height * 3;
                RGBvalues = new byte[numberOfBytes];

                bmpData = bmp.LockBits(obszar, ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);

                dataBegin = bmpData.Scan0;
                Marshal.Copy(dataBegin, RGBvalues, 0, numberOfBytes);

                for (int i = 0; i < RGBvalues.Length; i += 3)
                {
                    var colorInRGB = new RGB(RGBvalues[i], RGBvalues[i + 1], RGBvalues[i + 2]);
                    var convertedRGBtoHSV = RgbToHsv(colorInRGB);
                    convertedRGBtoHSV.H = convertedRGBtoHSV.H> 128f? convertedRGBtoHSV.H+ 10f: convertedRGBtoHSV.H - 10f;
                    convertedRGBtoHSV.S = convertedRGBtoHSV.S;
                    convertedRGBtoHSV.V = convertedRGBtoHSV.V > 128f ? convertedRGBtoHSV.V + 5f : convertedRGBtoHSV.V - 5f;
                    var convertedHSVtoRGB = HsvToRgb(convertedRGBtoHSV);

                    RGBvalues[i] = (byte)(convertedHSVtoRGB.R);
                    RGBvalues[i + 1] = (byte)(convertedHSVtoRGB.G);
                    RGBvalues[i + 2] = (byte)(convertedHSVtoRGB.B);
                }
                Marshal.Copy(RGBvalues, 0, dataBegin, numberOfBytes);
                bmp.UnlockBits(bmpData);
                image = bmp;
                return image;
            }
            else
            {
                MessageBox.Show("Select an image first.");
                return null;
            }
        }
    }
}
