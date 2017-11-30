using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Image_Processing.Controllers.Extraction
{
    public class PlateRecognitionController
    {
        CommonController _commonController = new CommonController();
        private List<ColorArea> colorsToRemove = new List<ColorArea>();


        public Bitmap FloodByArea(Bitmap image)
        {
            ////var image = (Bitmap)img.Clone();
            int width = image.Width - 1;
            int height = image.Height - 1;
            colorsToRemove = new List<ColorArea>();

            for (int y = 1; y < height; y++)
            {
                for (int x = 1; x < width; x++)
                {
                    var inte = image.GetPixel(x, y);
                    if(inte.R == 255 && inte.B == 255 && inte.G == 255)
                    {
                        var teste = _commonController.FloodFillPoint(ref image, new Point(x, y), inte);
                        if(teste.Area < 80 )
                        {
                            colorsToRemove.Add(teste);
                        }
                    }
                    inte = image.GetPixel(x, y);
                    if (colorsToRemove.Any(c => c.Cor.ToArgb() == inte.ToArgb()))
                    {
                        image.SetPixel(x, y, Color.Black);
                    }
                }
            }

            return image;
        }
    }
    public class ColorArea
    {
        public Color Cor { get; set; }
       
        public int Area { get; set; }
    }
}
