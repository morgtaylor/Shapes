using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        private static double _DefaultRadius = 2;

        public double Radius { get; set; }

        public Circle()
        {
            Radius = _DefaultRadius;
        }

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public Circle(Circle circleToCopy)
        {
            this.Radius = circleToCopy.Radius;
        }

        public double CalculateArea()
        {
            double Area = Math.PI * Math.Pow(Radius, 2);
            return Area;
        }
        public double CalculatePerimeter()
        {
            double Peri = 2 * Math.PI * Radius;
            return Peri;
        }
    }
}

