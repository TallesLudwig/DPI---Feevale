using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Image_Processing.Controllers.Morphology
{
    class Erosion
    {
        public Image Run(Bitmap image, int[,] element)
        {
            Bitmap result = (Bitmap)image.Clone();
            int widthM1 = image.Width - 1;
            int heightM1 = image.Height - 1;

            for (int y = 1; y < heightM1; y++)
            {
                for (int x = 1; x < widthM1; x++)
                {
                    List<int> values = new List<int>();

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (element[i, j] > 0)
                            {
                                Color pixel = image.GetPixel(x + (i - 1), y + (j - 1));
                                values.Add((int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11));
                            }
                        }
                    }

                    var min = values.Min();

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            var eValue = element[i, j];
                            if (eValue > 0)
                            {
                                Color pixel = image.GetPixel(x + (i - 1), y + (j - 1));
                                var pValeu = min - eValue;
                                pValeu = pValeu <= 0 ? 0 : pValeu;
                                result.SetPixel(x, y, Color.FromArgb(pValeu, pValeu, pValeu));
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}


