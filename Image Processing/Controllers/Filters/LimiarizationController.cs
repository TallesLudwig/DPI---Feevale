using System;
using System.Drawing;

namespace Image_Processing.Controllers
{
    public class Limiarization
    {
        internal Image Run(int limit, Image image)
        {
            Bitmap img = (Bitmap)image.Clone();
            Bitmap novo = new Bitmap(img.Width, img.Height);
            for (Int32 y = 0; y < novo.Height; y++)
                for (Int32 x = 0; x < novo.Width; x++)
                {
                    Color c = img.GetPixel(x, y);
                    int gs = c.R;
                    if (gs > limit)
                        gs = 255;
                    else
                        gs = 0;
                    int trasn = c.A;
                    novo.SetPixel(x, y, Color.FromArgb(trasn, gs, gs, gs));
                }
            return novo;
        }
    }
}
