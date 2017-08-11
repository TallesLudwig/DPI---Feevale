using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDI_Talles.Controllers
{
    public class FileController
    {
        private byte[] bytes;
        public Bitmap originalImg;
        public Bitmap img;

        public Bitmap LoadImg(string file)
        {
            Bitmap bmp = new Bitmap(file);
            this.originalImg = bmp;
            this.img = bmp;
            ImageConverter convert = new ImageConverter();
            this.bytes = (byte[])convert.ConvertTo(bmp, typeof(byte[]));
            return bmp;
        }
    }
}
