using System;
using System.Windows.Forms;
using Image_Processing.Controllers;
using PDI_Talles.Forms;
using Image_Processing.Model;
using System.Drawing;

namespace Image_Processing.Controllers
{
    public class Sobel
    {
        public int Threshold = 100;
        private static int[,] xKernel = new int[,]
        {
            { 1, 0, -1 },
            { 2, 0, -2 },
            { 1, 0, -1 }
        };

        private static int[,] yKernel = new int[,]
        { 
            { 1, 2, 1 },
            { 0, 0, 0 },
            { -1, -2, -1 }
        };

        public Image Executar(Image image)
        {
            Bitmap originalImg = (Bitmap)image.Clone();
            Bitmap result = (Bitmap)originalImg.Clone();
            int widthM1 = image.Width - 1;
            int heightM1 = image.Height - 1;
            double v, gx, gy, g = 0;

            for (int y = 1; y < heightM1; y++)
            {
                for (int x = 1; x < widthM1; x++)
                {
                    gx = 0;
                    gy = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Color pixel = originalImg.GetPixel(x + (i - 1), y + (j - 1));
                            v = (pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                            gx += v * xKernel[i, j];
                            gy += v * yKernel[i, j];
                        }
                    }

                    g = Math.Sqrt(Math.Pow(gx, 2) + Math.Pow(gy, 2));
                    byte p = 0;
                    if (g > Threshold)
                    {
                        p = 255;
                    }
                    result.SetPixel(x, y, Color.FromArgb(p, p, p));
                }
            }
            return result;
        }
    }
}
