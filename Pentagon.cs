using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Pentagon : Shape
    {
        private static double _DefaultSideLength = 1;
        public double SideLength { get; set; }

        public Pentagon()
        {
            SideLength = _DefaultSideLength;
        }

        public Pentagon(double sideLength)
        {
            this.SideLength = sideLength;
        }

        public Pentagon(Pentagon pentagonToCopy)
        {
            this.SideLength = pentagonToCopy.SideLength;
        }

        public double CalculateArea()
        {
            double Area = 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(SideLength, 2);
            return Area;
        }
        public double CalculatePerimeter()
        {
            double Peri = 5 * SideLength;
            return Peri;
        }
    }
}
