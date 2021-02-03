using System;

namespace Project1_Sumof3
{
    class Program
    {
        static void Main(string[] args)
        {
            static double sum(double n1, double n2, double n3)
            in total;
            total = n1 + n2 + n3;
            return total;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Calculate sum of 3 numbers");
            Console.WriteLine("Enter number 1");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            double n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Calculate sum of 3 numbers is: { 0:F3}", sum(n1, n2, n3));

        }







    }
}
}
