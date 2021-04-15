using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Rectangle
    {
        public double Length { get; set; }

        public double Width { get; set; }

        public Rectangle()
        {
            Length = 7;
            Width = 7;
        }

        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }
        public double CalculateArea()
        {
            return Width * Length;
        }
        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
        public class Circle
        {

            public double Radius { get; set; }

            /// <summary>
            /// Empty constructor that sets the starting value of Radius to 0
            /// </summary>
            public Circle()
            {
                Radius = 0;

            }

            /// <summary>
            /// Calculates the area of this Circle
            /// </summary>
            /// <returns>The area of this circle</returns>
            public double CalculateArea()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }

            /// <summary>
            /// Calculates the Perimeter of this Circle
            /// </summary>
            /// <returns>The perimeter of this Circle</returns>
            public double CalculatePerimeter()
            {
                return 2 * Math.PI * Radius;
            }
            static void Main(string[] args)
            {
                // Create first instance of Rectangle
                Rectangle rect1 = new Rectangle();
                rect1.Length = 5;
                rect1.Width = 5;
                double area = rect1.CalculateArea();

                Console.WriteLine($"Rectangle 1: W:{rect1.Width}, L:{rect1.Length}, A:{area}, P:{rect1.CalculatePerimeter()}");

                // Create second instance of Rectangle
                Rectangle rect2 = new Rectangle(25.5, 3.33);
                Console.WriteLine($"Rectangle 2: W:{rect2.Width}, L:{rect2.Length}, A:{rect2.CalculateArea()}, P:{rect2.CalculatePerimeter()}");

                Circle circ1 = new Circle();
                circ1.Radius = 3.33;
                Console.WriteLine($"Circle 1: R:{circ1.Radius}, A:{circ1.CalculateArea()}, P:{circ1.CalculatePerimeter()}");

                Circle circ2 = new Circle();
                circ2.Radius = 9.66;
                Console.WriteLine(circ2);
                Console.WriteLine($"Circle 2: R:{circ2.Radius}, A:{circ2.CalculateArea()}, P:{circ2.CalculatePerimeter()}");
            }
        }
    }
}


