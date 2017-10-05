using Image_Processing.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace PDI_Talles.Controllers
{
    public class FileController
    {
        public Bitmap originalImg;
        public Bitmap img;

        public Bitmap LoadImg(string file)
        {
            Bitmap bmp = new Bitmap(file);
            this.originalImg = bmp;
            this.img = bmp;
            ImageConverter convert = new ImageConverter();

            return bmp;
        }

        public Bitmap GetOriginalImage()
        {
            this.img = originalImg;
            return this.originalImg;
        }

        public Bitmap ChangeBiggerValues(Bitmap imagem, float ruler, int newValue)
        {
            Bitmap novo = new Bitmap(imagem.Width, imagem.Height);
            for (Int32 y = 0; y < novo.Height; y++)
                for (Int32 x = 0; x < novo.Width; x++)
                {
                    Color c = imagem.GetPixel(x, y);
                    int gs = c.R;
                    if (gs >= ruler)
                        gs = newValue;
                    int trasn = c.A;
                    novo.SetPixel(x, y, Color.FromArgb(trasn, gs, gs, gs));
                }

            return novo;
        }

        public Bitmap ChangeLowerValues(Bitmap imagem, float ruler, int newValue)
        {
            Bitmap novo = new Bitmap(imagem.Width, imagem.Height);
            for (Int32 y = 0; y < novo.Height; y++)
                for (Int32 x = 0; x < novo.Width; x++)
                {
                    Color c = imagem.GetPixel(x, y);
                    int gs = c.R;
                    if (gs < ruler)
                        gs = newValue;
                    int trasn = c.A;
                    novo.SetPixel(x, y, Color.FromArgb(trasn, gs, gs, gs));
                }

            return novo;
        }

        public Bitmap ChangeBiggerValuesAndLowerValues(Bitmap imagem, float rulerA, float rulerB, int newValueA, int newValueB)
        {
            Bitmap novo = new Bitmap(imagem.Width, imagem.Height);
            for (Int32 y = 0; y < novo.Height; y++)
                for (Int32 x = 0; x < novo.Width; x++)
                {
                    Color c = imagem.GetPixel(x, y);
                    int gs = c.R;
                    if (gs < rulerA)
                        gs = newValueA;
                    else if (gs > rulerB)
                        gs = newValueB;
                    int trasn = c.A;
                    novo.SetPixel(x, y, Color.FromArgb(trasn, gs, gs, gs));
                }

            return novo;
        }
    }
}
