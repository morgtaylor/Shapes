using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Shape
    {
        private static double _DefaultSideLength = 1;
        public double SideLength { get; set; }

        public Square() 
        {
            SideLength = _DefaultSideLength;
        }

        public Square(double sideLength)
        {
            this.SideLength = sideLength;
        }

        public Square(Square squareToCopy)
        {
            this.SideLength = squareToCopy.SideLength;
        }

        public double CalculateArea()
        {
           double Area = SideLength * SideLength;
            return Area;
        }
        public double CalculatePerimeter()
        {
            double Peri = 4 * SideLength;
            return Peri;
        }
    }
}
