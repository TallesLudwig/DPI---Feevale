using Image_Processing.Model;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Image_Processing.Controllers.Extraction
{
    public class SquareExtractionController
    {
        private List<Square> Squares = new List<Square>();
        readonly CommonController _commonController = new CommonController();

        #region Masks

        private static int[,] Square0 = new int[,] {
            { 0, 0, 0 },
            { 0, 255, 255 },
            { 0, 255, 255 }
        };

        private static int[,] Square1 = new int[,]
        {
            { 0, 0, 0 },
            { 255, 255, 0 },
            { 255, 255, 0 }
        };

        private static int[,] Square2 = new int[,]
        {
            { 0, 255, 255 },
            { 0, 255, 255 },
            { 0, 0, 0 }
        };

        private static int[,] Square3 = new int[,]
        {
            { 255, 255, 0 },
            { 255, 255, 0 },
            { 0, 0, 0 }
        };

        #endregion


        ////public Rectangle[] EasyWay(System.Drawing.Image original)
        ////{
        ////    // create an instance of blob counter algorithm
        ////    BlobCounter bc = new BlobCounter();
        ////    // process binary image
        ////    bc.ProcessImage((Bitmap)original);
        ////    Rectangle[] rects = bc.GetObjectsRectangles();
        ////    // process blobs

        ////    return rects;
        ////}

        public List<Square> SquareExtraction(System.Drawing.Image original)
        {
            this.Squares = new List<Square>();

            Bitmap image = (Bitmap)original.Clone();
            int width = image.Width - 1;
            int height = image.Height - 1;

            _commonController.ToBlackWhite(ref image, width, height);

            for (int y = 1; y < height; y++)
            {
                for (int x = 1; x < width; x++)
                {
                    ValidadeMasks((Bitmap)original, y, x);
                }
            }

            return Squares;
        }

        #region Masks

        private void ValidadeMasks(Bitmap image, int y, int x)
        {
            var isSquaresNotEmpyt = Squares.Any();
            if (ValidadeMask(image, y, x, Square0))
            {
                var newSquare = new Square() { Location0 = new Point() { X = x, Y = y } };
                Squares.Add(newSquare);
            }
            else if (isSquaresNotEmpyt && ValidadeMask(image, y, x, Square1))
            {
                var squareMach = Squares.LastOrDefault(s => s.Location0.Y == y);
                if (squareMach != null)
                {
                    squareMach.Location1 = new Point() { X = x, Y = y };

                }
            }
            else if (isSquaresNotEmpyt && ValidadeMask(image, y, x, Square2))
            {
                var squareMach = Squares.LastOrDefault(s => s.Location0.X == x);
                if (squareMach != null)
                {
                    squareMach.Location2 = new Point() { X = x, Y = y };
                }
            }
            else if (isSquaresNotEmpyt && ValidadeMask(image, y, x, Square3))
            {
                var squareMach = Squares.LastOrDefault(s => s.Location1.X == x && s.Location2.Y == y);
                if (squareMach != null)
                {
                    squareMach.Location3 = new Point() { X = x, Y = y };
                    squareMach.isCompleted = true;
                }
            }
        }

        private bool ValidadeMask(Bitmap image, int y, int x, int[,] mask)
        {
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Color pixel = image.GetPixel(x + (j - 1) , y + (i - 1));
                    var maskValue = mask[i, j];
                    if (pixel.R != maskValue)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        #endregion
        
    }
}
