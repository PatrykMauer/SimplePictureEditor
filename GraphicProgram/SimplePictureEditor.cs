using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GraphicProgram
{
    public partial class SimplePictureEditor : Form
    {
        Bitmap bitmap;
        public SimplePictureEditor()
        {
            InitializeComponent();
           
        }
        private void saveFileButton_Click(object sender, EventArgs e)
        {
            FileManagment.SaveFile.saveFile(saveFile, canvas);
        }


        private void openFileButton_click(object sender, EventArgs e)
        {
            bitmap = FileManagment.OpenFile.openBitmapFile(openFile);
            if (bitmap != null)
            {
                canvas.Image = bitmap;
                canvas.Width = bitmap.Width;
                canvas.Height = bitmap.Height;
            }
        }

        private void sharpenButton_Click(object sender, EventArgs e)
        {
            var value = ConvertTrackBarValue.ConvertTrackBarValues(sharpenTrackBar.Value);
            this.canvas.Image = Sharpen.setSharpen(bitmap, value);
            canvas.Refresh();
        }

        private void blurButton_Click(object sender, EventArgs e)
        {
            this.canvas.Image = Blur.setBlur(bitmap, blurTrackBar.Value);
        }

        private void contrastTrackBar_Scroll(object sender, EventArgs e)
        {
            canvas.Image = Contrast.SetContrast(bitmap, contrastTrackBar.Value);
            canvas.Refresh();
        }

        private void brightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            canvas.Image = Brightness.SetBrightness(bitmap, BrightnessTrackBar.Value);
            canvas.Refresh();
        }

        private void gammaTrackBar_Scroll(object sender, EventArgs e)
        {
            canvas.Image = Gamma.setGamma(bitmap, gammaSlideBar.Value);
            canvas.Refresh();
        }

        private void embossButton_Click(object sender, EventArgs e)
        {
            canvas.Image = Emboss.detectEmboss(bitmap);
            canvas.Refresh();
        }

        private void blackAndWhiteButton_Click(object sender, EventArgs e)
        {
            canvas.Image = Effects.grayScale.setGrayScale(bitmap);
            canvas.Refresh();
        }

        private void negativeSlowButton_Click(object sender, EventArgs e)
        {
            canvas.Image = Effects.Negative.setNegativeSlow(bitmap);
            canvas.Refresh();
        }

        private void negativeFastButton_Click(object sender, EventArgs e)
        {
            canvas.Image = Effects.Negative.setNegativeFast(bitmap);
            canvas.Refresh();
        }

        private void colorButton_click(object sender, EventArgs e)
        {
            PickHSV.Color(canvas.Image);
            this.canvas.Refresh();
        }

        private void unknownEffectButton_Click(object sender, EventArgs e)
        {
            PickHSV.Idk(canvas.Image);
            this.canvas.Refresh();
        }

        private void unknownEffectButton_2_Click(object sender, EventArgs e)
        {
            PickHSV.Contrast(canvas.Image);
            this.canvas.Refresh();
        }

        private void histogramButton_Click(object sender, EventArgs e)
        {
            Effects.Histogram.seeHistogram(bitmap);
            this.canvas.Refresh();
        }

        private void otsuThresholdButton_Click(object sender, EventArgs e)
        {
            Effects.OtsuThreshold.ApplyOtsuThreshold(ref bitmap);
            this.canvas.Refresh();
    
        }
    }
}

