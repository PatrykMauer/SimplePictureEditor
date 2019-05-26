using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicProgram.FileManagment
{
    public static class SaveFile
    {
        public static void saveFile(SaveFileDialog saveDialog, PictureBox canvas)
        {

            saveDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveDialog.Title = "Save an Image File";
            saveDialog.ShowDialog();

            if (saveDialog.FileName != "")
            {
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveDialog.OpenFile();
                switch (saveDialog.FilterIndex)
                {
                    case 1:
                        canvas.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        canvas.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        canvas.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }
                fs.Close();
            }
        }
    }
}
