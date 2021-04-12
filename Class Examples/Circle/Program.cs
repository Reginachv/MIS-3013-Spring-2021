using System;
using System.Collections.Generic;
using System.Text;

namespace Circle
{
    class Program
    {
        public class Circle

        {
            public double Radius { get; set; }
            /// <summary>
            /// Empty constructor that sets the starting value of Raidus to 0
            /// </summary>
            public Circle()
            {
                Radius = 0;
            }
            /// <summary>
            /// Calculates the are of this circle
            /// </summary>
            /// <returns> The area of this circle</returns>

            public double CalculateArea()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
            /// <summary>
            /// Calculates the Perimeter of this Circle
            /// </summary>
            /// <returns>The perimeter of this circle</returns>
            public double CalculatePerimeter()
            {
                return 2 * Math.PI * Radius;
            }
            
               
        }
    }
}
