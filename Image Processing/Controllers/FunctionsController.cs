using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Image_Processing.Controllers
{
    public class FunctionsController
    {
        double[,] matriz = new double[3, 3];

        private Image CalculateMatriz(Image original)
        {
            Bitmap img = new Bitmap(original);
            Bitmap newImg = new Bitmap(original.Width, original.Height);
            int x = original.Width;
            int y = original.Height;
            double[,] result = new double[1, 3];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    result[0, 0] = (i * matriz[0, 0]) + (j * matriz[0, 1]) + (1 * matriz[0, 2]);
                    if (result[0, 0] < 0)
                    {
                        result[0, 0] += x;
                    }
                    result[0, 1] = (i * matriz[1, 0]) + (j * matriz[1, 1] + (1 * matriz[1, 2]));
                    if (result[0, 1] < 0)
                    {
                        result[0, 1] += y;
                    }
                    if (result[0, 0] > 0 && result[0, 1] > 0)
                    {
                        if ((int)result[0, 0] < newImg.Width && (int)result[0, 1] < newImg.Height)
                            newImg.SetPixel((int)result[0, 0], (int)result[0, 1], img.GetPixel(i, j));

                    }
                }
            }
            return newImg;
        }

        internal Image Shrink(Bitmap picture)
        {
            SetMatrizShrink();
            return CalculateMatriz(picture);
        }

        internal Image Stretch(Bitmap picture)
        {
            SetMatrizStretch();
            return CalculateMatriz(picture);
        }

        internal Image RotateClockwise(float angle, Bitmap picture)
        {
            SetMatrizClockwise(angle);
            return CalculateMatriz(picture);
        }

        internal Image RotateAnticlockwise(float angle, Bitmap picture)
        {
            SetMatrizAnticlockwise(angle);
            return CalculateMatriz(picture);
        }

        internal Image VerticalMirroring(Bitmap picture)
        {
            SetMatrizVerticalMirroring();
            return CalculateMatriz(picture);
        }

        internal Image HorizontaMirroring(Bitmap picture)
        {
            SetMatrizHorizontalMirroring();
            return CalculateMatriz(picture);
        }

        private void SetMatrizHorizontalMirroring()
        {
            matriz[0, 0] = -1; matriz[1, 0] = 0; matriz[2, 0] = 0;
            matriz[0, 1] = 0; matriz[1, 1] = 1; matriz[2, 1] = 0;
            matriz[0, 2] = 0; matriz[1, 2] = 0; matriz[2, 2] = 1;
        }

        private void SetMatrizVerticalMirroring()
        {
            matriz[0, 0] = 1; matriz[1, 0] = 0; matriz[2, 0] = 0;
            matriz[0, 1] = 0; matriz[1, 1] = -1; matriz[2, 1] = 0;
            matriz[0, 2] = 0; matriz[1, 2] = 0; matriz[2, 2] = 1;
        }

        private void SetMatrizClockwise(double angle)
        {
            double rad = (angle * Math.PI) / 180;
            matriz[0, 0] = (Math.Cos(rad)); matriz[1, 0] = Math.Sin(rad); matriz[2, 0] = 0;
            matriz[0, 1] = -Math.Sin(rad); matriz[1, 1] = Math.Cos(rad); matriz[2, 1] = 0;
            matriz[0, 2] = 0; matriz[1, 2] = 0; matriz[2, 2] = 1;
        }

        private void SetMatrizAnticlockwise(double angle)
        {
            double rad = (angle * Math.PI) / 180;
            matriz[0, 0] = (Math.Cos(rad)); matriz[1, 0] = -Math.Sin(rad); matriz[2, 0] = 0;
            matriz[0, 1] = Math.Sin(rad); matriz[1, 1] = Math.Cos(rad); matriz[2, 1] = 0;
            matriz[0, 2] = 0; matriz[1, 2] = 0; matriz[2, 2] = 1;
        }

        private void SetMatrizShrink()
        {
            matriz[0, 0] = 0.5; matriz[1, 0] = 0; matriz[2, 0] = 0;
            matriz[0, 1] = 0; matriz[1, 1] = 0.5; matriz[2, 1] = 0;
            matriz[0, 2] = 0; matriz[1, 2] = 0; matriz[2, 2] = 1;
        }
        private void SetMatrizStretch()
        {
            matriz[0, 0] = 2; matriz[1, 0] = 0; matriz[2, 0] = 0;
            matriz[0, 1] = 0; matriz[1, 1] = 2; matriz[2, 1] = 0;
            matriz[0, 2] = 0; matriz[1, 2] = 0; matriz[2, 2] = 1;
        }
    }
}
