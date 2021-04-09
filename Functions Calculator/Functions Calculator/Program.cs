using System;

namespace Functions_Calculator
{
    class Program
    {
        static int method;
        static double val1, val2;
        static Boolean t = false;
        static string name, className, date;
        static void Main(string[] args)
        {
            DeveloperInformation(name, className, date);


            char c = 'n';
            do
            {
                if (!t)
                {
                    Methods();
                    InputNumbers(); // values
                    t = true;
                }
                switch (method) //method user chooses from list
                {
                    case 1:
                        double addition = Add(val1, val2);
                        Console.WriteLine("Addition is: " + addition);
                        break;
                    case 2:
                        double subtraction = Subtract(val1, val2);
                        Console.WriteLine("Subtraction is: " + subtraction);
                        break;
                    case 3:
                        double multiplication = Multiply(val1, val2);
                        Console.WriteLine("Multiplication is: " + multiplication);
                        break;
                    case 4:
                        double division = Divide(val1, val2);
                        Console.WriteLine("Division is: " + division);
                        break;
                    default:
                        Console.WriteLine("Error! Invalid method");
                        break;
                }
                /*string answer;
                string numbers;

                Console.WriteLine("\nWould you like to use a different method yes or no?");
                answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine("Do you want to try with different numbers yes or no?");
                    numbers = Console.ReadLine();
                    if (numbers == "y")
                    {
                        InputNumbers();
                        Methods();
                    }
                    else
                    {
                        Methods();
                    }
                }
                else
                {
                    Console.WriteLine("Thanks for trying the methods!!");
                } while (answer == "y") */

                Console.WriteLine("\nWould you like to use a different method yes or no?"); //ran into problems with other loops
                 c = Convert.ToChar(Console.ReadLine());
                 if (c == 'y') //assuming user inout yes or no
                 {
                     Console.WriteLine("Do you want to try with different numbers yes or no?");
                     char variable = Convert.ToChar(Console.ReadLine());
                     if (variable == 'y')
                     {
                         InputNumbers();
                         Methods();
                     }
                     else
                     {
                         Methods();
                     }
                 }
                 else
                 {
                     Console.WriteLine("Thanks for trying the methods!!");
                 }
             } while (c == 'y'); 

            } 
        static void DeveloperInformation(string name, string className, string date)
        {
            Console.WriteLine("What is your first and last name");
            name = Console.ReadLine();
            Console.WriteLine("What is your class name");
            className = Console.ReadLine();
            Console.WriteLine("What is the date");
            date = Console.ReadLine();
            Console.WriteLine("Developer information of: " +  name + "\nClass:" + className + "\nToday's Date:" + date);
        } 
                
        private static void InputNumbers() 
        {
            Console.WriteLine("Enter an first number:");
            val1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter an second number:");
            val2 = Convert.ToDouble(Console.ReadLine());
        }

        private static void Methods() 
        {
            Console.WriteLine("\nChoose a method of the following\n1.Add\n2.Subtract\n3.Multiply\n4.Divide");
            Console.WriteLine("\nEnter an option:");
            method = Convert.ToInt32(Console.ReadLine());
        }


        private static double Add(double val1, double val2) 
        {
            return val1 + val2;
        }

        private static double Subtract(double val1, double val2) 
        {
            return val1 - val2;
        }

        private static double Multiply(double val1, double val2) 
        {
            return val1 * val2;
        }


        private static double Divide(double val1, double val2) 
        {
           return  val1 / val2;
        }
    }
}
