using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var square1 = new Square(); //default
            var square2 = new Square(4); //parameterized
            var square3 = new Square(square2); //copy

            Console.WriteLine("Square");
            Console.WriteLine(String.Format("Default Square: Sidelength - {0}, Area - {1}, Perimeter - {2}", square1.SideLength, square1.CalculateArea(), square1.CalculatePerimeter()));
            Console.WriteLine(String.Format("Parameterized Square: Sidelength - {0}, Area - {1}, Perimeter - {2}", square2.SideLength, square2.CalculateArea(), square2.CalculatePerimeter()));
            Console.WriteLine(String.Format("Copy Square: Sidelength - {0}, Area - {1}, Perimeter - {2}", square3.SideLength, square3.CalculateArea(), square3.CalculatePerimeter()));
            Console.WriteLine();

            var rect1 = new Rectangle(); //default
            var rect2 = new Rectangle(4, 5); //parameterized
            var rect3 = new Rectangle(rect2); //copy

            Console.WriteLine("Rectangle");
            Console.WriteLine(String.Format("Default Rectangle: Height - {0}, Width - {1}, Area - {2}, Perimeter - {3}", rect1.Height, rect1.Width, rect1.CalculateArea(), rect1.CalculatePerimeter()));
            Console.WriteLine(String.Format("Parameterized Rectangle: Height - {0}, Width - {1}, Area - {2}, Perimeter - {3}", rect2.Height, rect2.Width, rect2.CalculateArea(), rect2.CalculatePerimeter()));
            Console.WriteLine(String.Format("Copy Rectangle: Height - {0}, Width - {1}, Area - {2}, Perimeter - {3}", rect3.Height, rect3.Width, rect3.CalculateArea(), rect3.CalculatePerimeter()));
            Console.WriteLine();

            var circle1 = new Circle(); //default
            var circle2 = new Circle(5); //parameterized
            var circle3 = new Circle(circle2); //copy

            Console.WriteLine("Circle");
            Console.WriteLine(String.Format("Default Circle: Radius - {0}, Area - {1}, Perimeter - {2}", circle1.Radius, circle1.CalculateArea(), circle1.CalculatePerimeter()));
            Console.WriteLine(String.Format("Parameterized Circle: Radius - {0}, Area - {1}, Perimeter - {2}", circle2.Radius, circle2.CalculateArea(), circle2.CalculatePerimeter()));
            Console.WriteLine(String.Format("Copy Circle: Radius - {0}, Area - {1}, Perimeter - {2}", circle3.Radius, circle3.CalculateArea(), circle3.CalculatePerimeter()));
            Console.WriteLine();

            var ellipse1 = new Ellipse(); //default
            var ellipse2 = new Ellipse(3, 6); //parameterized
            var ellipse3 = new Ellipse(ellipse2); //copy

            Console.WriteLine("Ellipse");
            Console.WriteLine(String.Format("Default Ellipse: Short Radius - {0}, Long Radius - {1}, Area - {2}, Perimeter - {3}", ellipse1.ShortRadius, ellipse1.LongRadius, ellipse1.CalculateArea(), ellipse1.CalculatePerimeter()));
            Console.WriteLine(String.Format("Parameterized Ellipse: Short Radius - {0}, Long Radius - {1}, Area - {2}, Perimeter - {3}", ellipse2.ShortRadius, ellipse2.LongRadius, ellipse2.CalculateArea(), ellipse2.CalculatePerimeter()));
            Console.WriteLine(String.Format("Copy Ellipse: Short Radius - {0}, Long Radius - {1}, Area - {2}, Perimeter - {3}", ellipse3.ShortRadius, ellipse3.LongRadius, ellipse3.CalculateArea(), ellipse3.CalculatePerimeter()));
            Console.WriteLine();

            var pentagon1 = new Pentagon(); //default
            var pentagon2 = new Pentagon(3); //parameterized
            var pentagon3 = new Pentagon(pentagon2); //copy

            Console.WriteLine("Pentagon");
            Console.WriteLine(String.Format("Default Pentagon: Side Length - {0}, Area - {1}, Perimeter - {2}", pentagon1.SideLength, pentagon1.CalculateArea(), pentagon1.CalculatePerimeter()));
            Console.WriteLine(String.Format("Parameterized Pentagon: Sidelength - {0}, Area - {1}, Perimeter - {2}", pentagon2.SideLength, pentagon2.CalculateArea(), pentagon2.CalculatePerimeter()));
            Console.WriteLine(String.Format("Copy Pentagon: Side Length - {0}, Area - {1}, Perimeter - {2}", pentagon3.SideLength, pentagon3.CalculateArea(), pentagon3.CalculatePerimeter()));
            Console.WriteLine();

            //user input
            Console.WriteLine();
            Console.WriteLine();

            //square
            Console.WriteLine("Square");
            Console.WriteLine("Length of Side:");
            string input = Console.ReadLine() + "\n";
            if (double.TryParse(input, out double sideLength))
            {
                var square = new Square(sideLength);
                Console.WriteLine($"Area: {square.CalculateArea()}");
                Console.WriteLine($"Perimeter: {square.CalculatePerimeter()}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the side length.");
            }
            Console.WriteLine();

            //rectangle
            Console.WriteLine("Rectangle");
            Console.WriteLine("Height:");
            string heightInput = Console.ReadLine();
            Console.WriteLine("Width:");
            string widthInput = Console.ReadLine();

            if (double.TryParse(heightInput, out double height) && double.TryParse(widthInput, out double width))
            {
                var rectangle = new Rectangle(height, width);

                Console.WriteLine($"Area: {rectangle.CalculateArea()}");
                Console.WriteLine($"Perimeter: {rectangle.CalculatePerimeter()}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers for the height and width.");
            }
            Console.WriteLine();

            //circle
            Console.WriteLine("Circle");
            Console.WriteLine("Radius:");
            string radiusInput = Console.ReadLine() + "\n";
            if (double.TryParse(radiusInput, out double Radius))
            {
                var circle = new Circle(Radius);
                Console.WriteLine($"Area: {circle.CalculateArea()}");
                Console.WriteLine($"Perimeter: {circle.CalculatePerimeter()}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the radius.");
            }
            Console.WriteLine();

            //ellipse
            Console.WriteLine("Ellipse");
            Console.WriteLine("Short Radius:");
            string ShortInput = Console.ReadLine();
            Console.WriteLine("Long Radius:");
            string LongInput = Console.ReadLine();

            if (double.TryParse(ShortInput, out double shortRad) && double.TryParse(LongInput, out double longRad))
            {
                var ellipse = new Ellipse(shortRad, longRad);

                Console.WriteLine($"Area: {ellipse.CalculateArea()}");
                Console.WriteLine($"Perimeter: {ellipse.CalculatePerimeter()}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers for the short and long radii.");
            }
            Console.WriteLine();

            //pentagon
            Console.WriteLine("Pentagon");
            Console.WriteLine("Length of Side:");
            string pentSide = Console.ReadLine() + "\n";
            if (double.TryParse(pentSide, out double pentSideL))
            {
                var pentagon = new Pentagon(pentSideL);
                Console.WriteLine($"Area: {pentagon.CalculateArea()}");
                Console.WriteLine($"Perimeter: {pentagon.CalculatePerimeter()}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the side length.");
            }

            Console.ReadLine();
        }
    }
}
