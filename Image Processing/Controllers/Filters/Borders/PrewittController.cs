using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Image_Processing.Controllers
{
    public class Prewitt
    {
        private static int[,] xKernel = new int[,]
        {
        { -1, 0, 1 },
        { -1, 0, 1 },
        { -1, 0, 1 }
        };

        private static int[,] yKernel = new int[,]
        {
        { 1, 1, 1 },
        { 0, 0, 0 },
        { -1, -1, -1 }
        };

        public Image Executar(Image image)
        {
            Bitmap originalImg = (Bitmap)image.Clone();
            Bitmap result = (Bitmap)originalImg.Clone();
            int width = image.Width;
            int height = image.Height;
            int widthM1 = width - 1;
            int heightM1 = height - 1;
            int i, j;
            double v, gx, gy, g = 0;

            for (int y = 1; y < heightM1; y++)
            {
                for (int x = 1; x < widthM1; x++)
                {
                    gx = 0;
                    gy = 0;
                    for (i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            Color pixel = originalImg.GetPixel(x + (i - 1), y + (j - 1));

                            v = (pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);

                            gx += v * xKernel[i, j];
                            gy += v * yKernel[i, j];
                        }
                    }
                    g = Math.Sqrt((gx * gx) +(gy * gy));

                    if (g > 255)
                    {
                        g = 255;
                    }
                    else if (g < 0)
                    {
                        g = 0;
                    }

                    result.SetPixel(x, y, Color.FromArgb((byte)g, (byte)g, (byte)g));
                }
            }
            return result;
        }
    }
}