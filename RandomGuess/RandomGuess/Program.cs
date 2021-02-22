using System;

namespace RandomGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNbr = rand.Next(1, 11);

            Console.WriteLine($"randomNbr");

            Console.WriteLine("\nGuess a number between 1 and 10");
            Console.ReadLine();
        }
    }
}
