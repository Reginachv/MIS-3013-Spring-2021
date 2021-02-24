using System;

namespace RandomGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNbr = rand.Next(1, 11);
            int guess = 0;

            Console.WriteLine("\nI am thinking of a number between 1 and 10, can you guess what it is?");
            Console.ReadLine();

            /*
                do
            {
                Int32.TryParse(Console.ReadLine(), out guess);
                if (guess > 10 || guess < 1)
                    Console.WriteLine("Please choose a number between 1 and 10");
            } while (guess > 10 || guess < 1);

            for (int i = 0; i < guess; i++)
                Console.WriteLine("Please choose a number between 1 and 10");
                Console.ReadLine();  **/
           
            while (guess != randomNbr)
            {
                Console.WriteLine("Sorry, Please Try Again");
                Console.ReadLine();

                guess = Convert.ToInt32(Console.ReadLine());
            }
            while (guess == randomNbr)
            {
                Console.WriteLine("Great Job! Your guess was correct");
                Console.ReadLine();
            }
        }
    }
}
    
