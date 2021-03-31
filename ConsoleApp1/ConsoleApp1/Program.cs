using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = Add(3, 4); 
        }
        // Another way of commenting it allows comments to pop up when inputting code.
        /// <summary>
        /// sums up two v
        /// </summary>
        /// <param name="val1">The left hand operand of the equations</param>
        /// <param name="val2">The right hand operand of the equations</param>
        /// <returns>The sum of the two numbers</returns>
        static double Add(double val1, double val2) // val1 and val2 are parameters (param)
        {
            double number = val1 + val2;
            return number;

            //return val1 + val2
        }
    }
}
