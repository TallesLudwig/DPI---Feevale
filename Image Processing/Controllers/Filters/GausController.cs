using System;
using System.Windows.Forms;
using Image_Processing.Controllers;
using PDI_Talles.Forms;
using Image_Processing.Model;
using System.Drawing;

namespace Image_Processing.Controllers
{
    public class Gaus
    {
        private ImageModel mainImage;
        private int[,] mask = new int[3, 3] {
                                                { 1,2,1},
                                                { 2,4,2},
                                                { 1,2,1}
                                               };

        public Gaus(ImageModel mainImage)
        {
            this.mainImage = mainImage;
        }

        internal Image RunGaus()
        {
            Bitmap result = (Bitmap)mainImage.Imagem.Clone();
            int widthM1 = mainImage.Imagem.Width - 1;
            int heightM1 = mainImage.Imagem.Height - 1;

            double z = 0;
            //Percorre a imagem pixel a pixel
            for (int y = 1; y < heightM1; y++)
            {
                for (int x = 1; x < widthM1; x++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Color pixel = mainImage.Imagem.GetPixel(x + (i - 1), y + (j - 1));
                            z += pixel.R * mask[i, j];
                        }
                    }

                    int gaussValue = (int)z / 16;
                    result.SetPixel(x + 1, y + 1, Color.FromArgb(gaussValue, gaussValue, gaussValue));

                    z = 0;
                }
            }
            return result;
        }
    }
}
