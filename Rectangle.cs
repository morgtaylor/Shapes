using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private static double _DefaultHeight = 3;
        private static double _DefaultWidth = 6;
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Height = _DefaultHeight;
            Width = _DefaultWidth;
        }

        public Rectangle(double Height, double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }

        public Rectangle(Rectangle RectangleToCopy)
        {
            this.Height = RectangleToCopy.Height;
            this.Width = RectangleToCopy.Width;
        }

        public double CalculateArea()
        {
            double Area = Height * Width;
            return Area;
        }
        public double CalculatePerimeter()
        {
            double Peri = (2 * Height) + (2 * Width);
            return Peri;
        }
    }
}
