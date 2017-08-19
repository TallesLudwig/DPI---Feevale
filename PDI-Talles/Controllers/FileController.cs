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

        public Bitmap GetOriginalImage()
        {
            this.img = originalImg;
            return this.originalImg;
        }

        public List<Bitmap> SliceImg(int parts)
        {
            var slicedImg = new List<Bitmap>();

            Rectangle rect = new Rectangle(0, 0, originalImg.Width / 2, originalImg.Height / 2);
            Bitmap i1 = originalImg.Clone(rect, originalImg.PixelFormat);
            slicedImg.Add(i1);

            rect = new Rectangle(originalImg.Width / 2, 0, originalImg.Width / 2, originalImg.Height / 2);
            Bitmap a2 = originalImg.Clone(rect, originalImg.PixelFormat);
            slicedImg.Add(a2);

            rect = new Rectangle(0, originalImg.Height / 2, originalImg.Width, originalImg.Height / 2);
            Bitmap i3 = originalImg.Clone(rect, originalImg.PixelFormat);
            slicedImg.Add(i3);

            rect = new Rectangle(originalImg.Width / 2, originalImg.Height / 2, originalImg.Width / 2, originalImg.Height / 2);
            Bitmap i4 = originalImg.Clone(rect, originalImg.PixelFormat);
            slicedImg.Add(i4);

            return slicedImg;
        }
    }
}
