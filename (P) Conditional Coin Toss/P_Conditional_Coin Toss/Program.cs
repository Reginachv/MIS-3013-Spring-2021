﻿using System;

namespace P_Conditional_Coin_Toss
{
    class Program
    {
        public static bool Head { get; private set; }

        static void Main(string[] args)
        {
            const string DEVELOPER_INFO = "Regina Chavez";

            Console.WriteLine("Guess heads by entering 1 or tails by entering 2 for a coin toss");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1)
            {
                Console.WriteLine("You guessed heads");
            }
            else
            {
                Console.WriteLine("You guessed tails");

                Random rand = new Random();
                int randomNbr = rand.Next(1, 3);
                Console.WriteLine($"{randomNbr}");

                if (randomNbr == 1)
                {
                Console.WriteLine("The coin landed on Heads");
                }
            else
                {
                Console.WriteLine("The coin landed on Tails");
                }
            if (randomNbr = answer)
                {
               Console.WriteLine("Your guess was correct");
                }
            else
                {
                Console.WriteLine("Your guess was incorrect, sorry :(");
                }
                Console.WriteLine($"Developed by {DEVELOPER_INFO}");
            }
        }
    }
}
