using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Image_Processing.Model
{
    public class Square
    {
        public Point Location0 { get; set; }

        public Point Location1 { get; set; }

        public Point Location2 { get; set; }

        public Point Location3 { get; set; }

        public bool isCompleted { get; set; }

        public int GetArea()
        {
            return (Location1.X - Location0.X) * (Location3.Y - Location1.Y);
        }

        public int GetPerimeter()
        {
            var area = (Location1.X - Location0.X) + (Location3.X - Location2.X) + (Location2.Y - Location0.Y) + (Location3.Y - Location1.Y);
            return area;
        }
    }
}
