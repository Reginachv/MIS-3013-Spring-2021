using System;

namespace Loops_Guess_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int randomNbr = rand.Next(1, 11);

            Console.WriteLine("\nI am thinking of a number between 1 and 10, can you guess what it is?");
            int guess = Convert.ToInt32(Console.ReadLine());

            while (guess > randomNbr)
            {
                Console.WriteLine($"No, that too high. Guess lower!");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            while (guess < randomNbr)
            {
                Console.WriteLine($"No, thats too low. Guess higher!");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            while (guess != randomNbr)
            {
                Console.WriteLine($"Sorry, Please Try Again");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Great Job! Your guess was correct its {randomNbr}");
        }
    }
}
