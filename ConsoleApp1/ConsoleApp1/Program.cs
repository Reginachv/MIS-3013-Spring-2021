using System;

namespace ConsoleApp1
{
    class Program
    {
        static int method;
        static bool t = false;
        static void Main(string[] args)
        {
            // DeveloperInformation(name, className, date);

            do
            {
                if (!t)
                {
                    MethodsInput();
                    t = true;
                }
                switch (method)
                {
                    case 1:
                        double sum = Add(3, 4);
                        Console.WriteLine(sum);
                        break;
                    case 2:
                        double difference = Subtract(3, 4);
                        Console.WriteLine(difference);
                        break;
                    case 3:
                        double multiplication = Multiply(3, 4);
                        Console.WriteLine(multiplication);
                        break;
                    case 4:
                        double Division = Divide(3, 4);
                        Console.WriteLine(Division);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

                Console.WriteLine("Do you want to try another method? yes or no");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    MethodsInput();

                } while (answer = 'y')



                // Another way of commenting it allows comments to pop up when inputting code.
                /// <summary>
                /// sums up two v
                /// </summary>
                /// <param name="val1">The left hand operand of the equations</param>
                /// <param name="val2">The right hand operand of the equations</param>
                /// <returns>The sum of the two numbers</returns>

                static void MethodsInput()
                {
                    int method;
                    Console.WriteLine("Methods \n1. Add\n2. Subtract\n3. Multiply\n4. Divide");
                    Console.WriteLine("\nPlease enter a method (e.g 1-4)");
                    method = Convert.ToInt32(Console.ReadLine());

                }
                /*static void DeveloperInformation(string name, string className, string date)
                {
                    //string DeveloperInfo; 
                    Console.WriteLine("What is your name");
                    name = Console.ReadLine();
                    Console.WriteLine("What is your class name");
                    className = Console.ReadLine();
                    Console.WriteLine("What is the date");
                    date = Console.ReadLine(); }*/


                static double Add(double val1, double val2) // val1 and val2 are parameters (param)
                {
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
                    return val1 / val2;
                }
            }
        }
    
        
    



