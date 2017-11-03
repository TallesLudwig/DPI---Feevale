using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Image_Processing.Controllers.Morphology
{
    public class Holt
    {
        public Image Run(Bitmap image)
        {
            Bitmap result = (Bitmap)image.Clone();
            int widthM1 = image.Width - 1;
            int heightM1 = image.Height - 1;

            for (int y = 0; y < heightM1; y++)
            {
                for (int x = 0; x < widthM1; x++)
                {
                    var p = image.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    int avg = (r + g + b) / 3;
                    avg = avg < 128 ? 0 : 255;     // Converting gray pixels to either pure black or pure white
                    result.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                }
            }
            var no_pixels_deleted = false;

            var toRemove = new List<Ponto>();
            while (no_pixels_deleted == false)
            {
                no_pixels_deleted = true;

                for (int y = 1; y < heightM1; y++)
                {
                    for (int x = 1; x < widthM1; x++)
                    {
                        Color pixel = result.GetPixel(x, y);
                        var value = pixel.R;

                        // Verifica somente para pixels pretos
                        // (somente para optimizar a velocidade)
                        if (value == 0)
                        {
                            // Verifica formula de sobrevivencia do
                            // pixel...
                            var edge = GetConectividade(result, x, y);

                            pixel = result.GetPixel(x + 1, y);
                            var L = pixel.R == 0;

                            pixel = result.GetPixel(x, y + 1);
                            var S = pixel.R == 0;

                            pixel = result.GetPixel(x, y - 1);
                            var N = pixel.R == 0;

                            pixel = result.GetPixel(x-1, y);
                            var O = pixel.R == 0;

                            var teste = L && S && (N || O);
                            if (edge && !teste)
                            {
                                // O pixel deve ser removido...
                                no_pixels_deleted = false;
                                Ponto ponto = new Ponto
                                {
                                    x = x,
                                    y = y
                                };

                                toRemove.Add(ponto);
                            }
                            else
                            {
                                var a = 1;
                                a++;
                            }
                        }
                    }
                }

                foreach (var pixel in toRemove)
                {
                    result.SetPixel(pixel.x, pixel.y, Color.White);
                }
                toRemove.Clear();

                for (int y = 1; y < heightM1; y++)
                {
                    for (int x = 1; x < widthM1; x++)
                    {
                        Color pixel = result.GetPixel(x, y);
                        var value = pixel.R;

                        // Verifica somente para pixels pretos
                        // (somente para optimizar a velocidade)
                        if (value == 0)
                        {
                            // Verifica formula de sobrevivencia do
                            // pixel...
                            var edge = GetConectividade(result, x, y);

                            pixel = result.GetPixel(x + 1, y);
                            var L = pixel.R == 0;

                            pixel = result.GetPixel(x, y + 1);
                            var S = pixel.R == 0;

                            pixel = result.GetPixel(x, y - 1);
                            var N = pixel.R == 0;

                            pixel = result.GetPixel(x - 1, y);
                            var O = pixel.R == 0;
                            var teste = O && N && (S || L);

                            if (edge && !teste)
                            {
                                // O pixel deve ser removido...
                                no_pixels_deleted = false;
                                Ponto ponto = new Ponto
                                {
                                    x = x,
                                    y = y
                                };

                                toRemove.Add(ponto);
                            }
                        }
                    }
                }

                foreach (var pixel in toRemove)
                {
                    result.SetPixel(pixel.x, pixel.y, Color.White);
                }
                toRemove.Clear();
            }

            for (int y = 1; y < heightM1; y++)
            {
                for (int x = 1; x < widthM1; x++)
                {
                    Color pixel = result.GetPixel(x, y);
                    var value = pixel.R;

                    if (value == 0)
                    {
                        pixel = result.GetPixel(x + 1, y);
                        var L = pixel.R == 0;

                        pixel = result.GetPixel(x, y + 1);
                        var S = pixel.R == 0;

                        pixel = result.GetPixel(x, y - 1);
                        var N = pixel.R == 0;

                        pixel = result.GetPixel(x - 1, y);
                        var O = pixel.R == 0;

                        pixel = result.GetPixel(x + 1, y - 1);
                        var NL = pixel.R == 0;

                        pixel = result.GetPixel(x - 1, y - 1);
                        var NO = pixel.R == 0;

                        pixel = result.GetPixel(x + 1, y + 1);
                        var SL = pixel.R == 0;

                        pixel = result.GetPixel(x - 1, y + 1);
                        var SO= pixel.R == 0;
                        
                        if (!(N && ((L && !NL && !SO && (!O || !S) || (O && !NO && !SL && (!L || !S))))) == false)
                        {
                            // O pixel deve ser removido...
                            result.SetPixel(x, y, Color.White);
                            continue;
                        }
                        if (!(S && ((L && !NL && !SO && (!O || !N) || (O && !NO && !SL && (!L || !N))))) == false)
                        {
                            // O pixel deve ser removido...
                            result.SetPixel(x, y, Color.White);

                        }
                    }
                }
            }

            return result;
        }

        private int GetNeighbors(Bitmap image, int x, int y)
        {
            int vizinhos = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((i - 1) != 0 || (j - 1) != 0)
                    {
                        Color pixel = image.GetPixel(x + (i - 1), y + (j - 1));
                        var value = pixel.R;

                        if (value == 0)
                            vizinhos++;
                    }
                }
            }

            return vizinhos;
        }

        private bool GetConectividade(Bitmap image, int x, int y)
        {
            var totalOfNeighbors = GetNeighbors(image, x, y);
            if (2 > totalOfNeighbors || totalOfNeighbors  > 6)
            {
                return false;
            }

            int conectividade = 0;
            Color pixelA = image.GetPixel(x, y - 1); //// N
            Color pixelB = image.GetPixel(x + 1, y - 1); //// NL
            var value = pixelA.R == 255 && pixelB.R == 0;
            if (value)
                conectividade++;

            pixelA = image.GetPixel(x + 1, y - 1); //// NL
            pixelB = image.GetPixel(x + 1, y); //// L
            value = pixelA.R == 255 && pixelB.R == 0;
            if (value)
                conectividade++;

            pixelA = image.GetPixel(x + 1, y); //// L
            pixelB = image.GetPixel(x + 1, y + 1); //// SL
            value = pixelA.R == 255 && pixelB.R == 0;
            if (value)
                conectividade++;

            pixelA = image.GetPixel(x + 1, y + 1); //// SL
            pixelB = image.GetPixel(x, y + 1); //// S
            value = pixelA.R == 255 && pixelB.R == 0;
            if (value)
                conectividade++;

            pixelA = image.GetPixel(x, y + 1); //// S
            pixelB = image.GetPixel(x - 1, y + 1); //// SO
            value = pixelA.R == 255 && pixelB.R == 0;
            if (value)
                conectividade++;

            pixelA = image.GetPixel(x - 1, y + 1); //// SO
            pixelB = image.GetPixel(x - 1, y); //// O
            value = pixelA.R == 255 && pixelB.R == 0;
            if (value)
                conectividade++;

            pixelA = image.GetPixel(x - 1, y); //// O
            pixelB = image.GetPixel(x - 1, y - 1); //// NO
            value = pixelA.R == 255 && pixelB.R == 0;
            if (value)
                conectividade++;

            pixelA = image.GetPixel(x - 1, y - 1); //// NO
            pixelB = image.GetPixel(x, y - 1); //// N
            value = pixelA.R == 255 && pixelB.R == 0;
            if (value)
                conectividade++;

            return conectividade == 1 ? true : false;
        }

    }

    public class Ponto
    {
        public int x { get; set; }

        public int y { get; set; }
    }
}