using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicProgram.FileManagment
{
    public static class OpenFile
    {
        public static Bitmap openBitmapFile(OpenFileDialog fileDialog)
        {
            DialogResult result = fileDialog.ShowDialog();
            Bitmap bitmap;
            bitmap = Bitmap.FromFile(fileDialog.FileName) as Bitmap;
            return bitmap;
        }
    }
}
