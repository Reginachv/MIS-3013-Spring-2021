using System;

namespace Class_Example_Feb10
{
    class Program
    {
        static void Main(string[] args)
        {
            const string DEVELOPER_INFO = "Regina Chavez";
            Random rand = new Random();
            int randomNumberBetween1and100 = rand.Next(1, 101);

            if (randomNumberBetween1and100 % 3 == 0)

            {
                Console.WriteLine("Fizz");

            }

            else if (randomNumberBetween1and100 % 5 == 0)

            {
                Console.WriteLine("Buzz");
            }

            else if (randomNumberBetween1and100 % 3 == 0 &
                randomNumberBetween1and100 % 5 == 0)

            {
                Console.WriteLine("Fizz Buzz");
            }
            else
            {
                Console.WriteLine($"{randomNumberBetween1and100}");
            }
             Console.WriteLine($"Developed by {DEVELOPER_INFO}");
        }
    }
}
