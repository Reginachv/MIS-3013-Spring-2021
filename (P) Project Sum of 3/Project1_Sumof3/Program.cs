using System;

namespace Project1_Sumof3
{
    class Program
    {
        static double sum(double num1, double num2, double num3)
        {
            double total;
            total = num1 + num2 + num3;
            return total;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n\nFunction to Calculate the sum of three numbers multiplied by constant Magic Number:\n");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("Enter number 1");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            double n3 = Convert.ToDouble(Console.ReadLine());
            const double MAGIC_NUMBER = 7.777;

            Console.WriteLine("\nThe sum of three numbers is : {0:F3} \n", sum(n1, n2, n3));

            Console.WriteLine("\nThe sum of three numbers muliplied by constant magic number is : {0:F3} \n", sum(n1, n2, n3) * MAGIC_NUMBER);
        }
    }
}
