using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  // 3 nd 4 are arguements

            double sum = Add(3, 4);
            double difference = Subtract(3, 4);
            double multiplication = Multiply(3, 4);
            double Division = Divide(3, 4); */

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
                // double number = val1 + val2;
                // return number;

                return val1 + val2;
            }
            static double Subtract(double val1, double val2) // val1 and val2 are parameters (param)
            {
                return val1 - val2;
            }
            static double Multiply(double val1, double val2) // val1 and val2 are parameters (param)
            {
                return val1 * val2;
            }
            static double Divide(double val1, double val2) // val1 and val2 are parameters (param)
            {
                // double number = val1 + val2;
                // return number;

                return val1 / val2;
            }
            /*static string (string name, string className, string date) // val1 and val2 are parameters (param)
            {

            } */
        }
    }



