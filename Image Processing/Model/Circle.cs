using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Image_Processing.Model
{
    public class Circle
    {
        public CirclePoint Point90 { get; set; }

        public CirclePoint Point180 { get; set; }

        public CirclePoint Point270 { get; set; }

        public CirclePoint Point360 { get; set; }

        public Point Center { get; set; }

        public Color Color { get; set; }

        public int AreaByPixel { get; set; }

        public double RadiusByPixel
        {
            get
            {
                return Math.Sqrt(AreaByPixel / Math.PI);

            }
        }

        public double PerimeterByPixel
        {
            get
            {
                return 2 * Math.PI * RadiusByPixel;
            }
        }

        public double CircularityByPixel
        {
            get
            {
                return (4 * Math.PI * AreaByPixel) / Math.Pow(PerimeterByPixel, 2);
            }
        }

        public int Radius
        {
            get
            {
                return Point360.Center.X - Center.X;
            }
        }

        public double Perimeter
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }

        public double AreaByRadius
        {
            get
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        public double CircularityByRadius
        {
            get
            {
                return (4 * Math.PI * AreaByRadius) / Math.Pow(Perimeter, 2);
            }
        }
    }

    public class CirclePoint
    {
        public Point Begin { get; set; }

        public Point Ending { get; set; }

        public Point Center
        {
            get
            {
                return new Point
                {
                    X = Begin.X + (Ending.X - Begin.X) / 2,
                    Y = Begin.Y + (Ending.Y - Begin.Y) / 2
                };
            }
        }
    }
}
