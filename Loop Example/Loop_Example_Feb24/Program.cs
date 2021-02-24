using System;

namespace Loop_Example_Feb24
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; 

            for (int i = 1; i <= 100; i ++)
            {
                sum = sum + i;
                //sum += i; if multiplication start off at 1
            }

            Console.WriteLine($"All the #'s added up from 1 and 100 is {sum.ToString()}");

            // string [] lines = File.ReadAllLines();
        }
    }
}
