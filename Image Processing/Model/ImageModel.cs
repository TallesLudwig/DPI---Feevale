using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Image_Processing.Model
{
    public class ImageModel
    {
        public ImageModel(Bitmap bmp)
        {
            this.Imagem = bmp;
            ImageConverter convert = new ImageConverter();

            Bytes = (byte[])convert.ConvertTo(bmp, typeof(byte[]));
        }

        public byte[] Bytes { get; set; }

        public Bitmap Imagem { get; set; }

        public float Media { get; set; }

        public int Mediana { get; set; }

        public float Variancia { get; set; }

        public int Moda { get; set; }

        public int BiggerThan { get; set; }

        public int LessThan { get; set; }

        public int[] Histograma = new int[256];

        public void IniImageModel()
        {
            Bitmap grayScale = new Bitmap(Imagem.Width, Imagem.Height);
            for (Int32 y = 0; y < grayScale.Height; y++)
                for (Int32 x = 0; x < grayScale.Width; x++)
                {
                    Color c = Imagem.GetPixel(x, y);
                    Int32 gs = (Int32)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                    int trasn = Imagem.GetPixel(x, y).A;
                    grayScale.SetPixel(x, y, Color.FromArgb(trasn, gs, gs, gs));
                }
            ImageConverter converter = new ImageConverter();
            this.Bytes = (byte[])converter.ConvertTo(grayScale, typeof(byte[]));
            this.Imagem = grayScale;
            SetMedia();
            SetMediana();
            SetVariancia();
            SetHistograma();
            SetModa();
            SetQuestionValues();
        }

        private void SetMedia()
        {
            int count = Bytes.Count();
            int soma = 0;
            for (int i = 0; i < Bytes.Count(); i++)
            {
                soma += Bytes[i];
            }
            this.Media = soma / count;
        }

        private void SetMediana()
        {
            List<byte> ordenada = Bytes.ToList();
            ordenada.Sort();
            this.Mediana = ordenada.ElementAt((int)Bytes.Count() / 2);
        }

        public void SetVariancia()
        {
            float var = 0;
            int count = 0;
            for (int y = 0; y < Imagem.Height; y++)
            {
                for (int x = 0; x < Imagem.Width; x++)
                {
                    Color c = Imagem.GetPixel(x, y);
                    var += (c.R - Media) * (c.R - Media);
                    count++;
                }
            }
            this.Variancia = var / count;
        }

        public void SetHistograma()
        {
            Histograma = new int[256];
            for (int y = 0; y < Imagem.Height; y++)
            {
                for (int x = 0; x < Imagem.Width; x++)
                {
                    Color c = Imagem.GetPixel(x, y);
                    Histograma[c.R]++;
                }
            }
        }

        private void SetModa()
        {
            int max = Histograma.Max();
            for (int i = 0; i < Histograma.Count(); i++)
            {
                if (Histograma[i] == max)
                {
                    Moda = (int)i;
                }
            }
        }

        private void SetQuestionValues() //// remover dps de entregar
        {
            int less = 0;
            int more = 0;
            for (int y = 0; y < Imagem.Height; y++)
            {
                for (int x = 0; x < Imagem.Width; x++)
                {
                    Color c = Imagem.GetPixel(x, y);
                    if (c.R < 100) {
                        less++;
                    }
                    if (c.R > 150)
                    {
                        more++;
                    }
                }
            }

            BiggerThan = more;
            LessThan = less;
        }
    }
}
