using System;
using System.Collections.Generic;
using System.Drawing;
using Image_Processing.Controllers.Extraction;
using Image_Processing.Model;

namespace Image_Processing.Controllers
{
    public class CommonController
    {
        #region Foodfill

        public void FloodFillCircle(ref Bitmap bmp, Circle circle, Color targetColor, Color replacementColor)
        {
            Stack<Point> pixels = new Stack<Point>();
            targetColor = bmp.GetPixel(circle.Center.X, circle.Center.Y);
            pixels.Push(circle.Center);
            circle.Color = replacementColor;

            while (pixels.Count > 0)
            {
                Point a = pixels.Pop();
                if (a.X < bmp.Width && a.X > 0 && a.Y < bmp.Height && a.Y > 0)//make sure we stay within bounds
                {

                    if (bmp.GetPixel(a.X, a.Y) == targetColor)
                    {
                        circle.AreaByPixel++;
                        bmp.SetPixel(a.X, a.Y, replacementColor);
                        pixels.Push(new Point(a.X - 1, a.Y));
                        pixels.Push(new Point(a.X + 1, a.Y));
                        pixels.Push(new Point(a.X, a.Y - 1));
                        pixels.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }
            return;
        }

        public ColorArea FloodFillPoint(ref Bitmap bmp, Point point, Color targetColor)
        {
            Stack<Point> pixels = new Stack<Point>();
            targetColor = bmp.GetPixel(point.X, point.Y);
            pixels.Push(point);
            var nextColor = RandonColor();

            var returnValue = new ColorArea
            {
                Cor = nextColor
            };

            while (pixels.Count > 0)
            {
                Point a = pixels.Pop();
                if (a.X < bmp.Width && a.X > 0 && a.Y < bmp.Height && a.Y > 0)//make sure we stay within bounds
                {

                    if (bmp.GetPixel(a.X, a.Y) == targetColor)
                    {
                        returnValue.Area++;
                        bmp.SetPixel(a.X, a.Y, nextColor);
                        pixels.Push(new Point(a.X - 1, a.Y));
                        pixels.Push(new Point(a.X + 1, a.Y));
                        pixels.Push(new Point(a.X, a.Y - 1));
                        pixels.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }
            return returnValue; 
        }

        #endregion

        #region ToBlackWhite

        public void ToBlackWhite(ref Bitmap result, int width, int height)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    var p = result.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    int avg = (r + g + b) / 3;
                    avg = avg < 128 ? 0 : 255;     // Converting gray pixels to either pure black or pure white
                    result.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                }
            }
        }
        #endregion


        private Color RandonColor()
        {
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            var returnValue = Color.FromKnownColor(randomColorName);
            return returnValue == Color.White || returnValue == Color.Black ? RandonColor () : returnValue;
        }
    }
}
