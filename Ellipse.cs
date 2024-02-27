using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Ellipse : Shape
    {
        private static double _DefaultShortRadius = 2;
        private static double _DefaultLongRadius = 4;

        public double ShortRadius { get; set; }
        public double LongRadius { get; set; }

        public Ellipse()
        {
            ShortRadius = _DefaultShortRadius;
            LongRadius = _DefaultLongRadius;
        }

        public Ellipse(double ShortRadius, double LongRadius)
        {
            this.ShortRadius = ShortRadius;
            this.LongRadius = LongRadius;
        }

        public Ellipse(Ellipse ellipseToCopy)
        {
            this.ShortRadius = ellipseToCopy.ShortRadius;
            this.LongRadius= ellipseToCopy.LongRadius;
        }

        public double CalculateArea()
        {
            double Area =  Math.PI * ShortRadius * LongRadius;
            return Area;
        }
        public double CalculatePerimeter()
        {
            double Peri =  Math.PI * (3 * (LongRadius + ShortRadius) - Math.Sqrt((3 * LongRadius + ShortRadius) * (LongRadius + 3 * ShortRadius)));
            return Peri;
        }
    }
}
