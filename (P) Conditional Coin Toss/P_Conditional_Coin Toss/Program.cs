using System;

namespace P_Conditional_Coin_Toss
{
    class Program
    {
        public static bool Head { get; private set; }

        static void Main(string[] args)
        {
            const string DEVELOPER_INFO = "Regina Chavez";

            int answer = 0;

            while(answer != 1 && answer != 2)
            {
                Console.WriteLine("Guess heads by entering 1 or tails by entering 2 for a coin toss");
                //Heads = 1
                //Tails = 2
                answer = Convert.ToInt32(Console.ReadLine());
            }

            if (answer == 1)
            {
                Console.WriteLine("You guessed HEADS");
            }
            else {
                Console.WriteLine("You guessed TAILS");
            }

            Random rand = new Random();
            int randomNbr = rand.Next(1, 3);
            Console.WriteLine($"{randomNbr}");

            if (randomNbr == 1)
            {
                Console.WriteLine("\nThe coin landed on HEADS");
            }
            else
            {
                Console.WriteLine("\nThe coin landed on TAILS");
            }
            if (randomNbr == answer)
            {
                Console.WriteLine("\nYour guess was correct");
            }
            else
            {
                Console.WriteLine("\nYour guess was incorrect, sorry :(");
            }
            Console.WriteLine($"\nDeveloped by {DEVELOPER_INFO}");
        }
    }
}
