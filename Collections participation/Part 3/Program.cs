using System;
using System.Collections.Generic;

namespace Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List string
            string answer;
            do
            {
                Console.WriteLine("Name one of your favorite things >>");
                string answer = Console.ReadLine();

                favoriteThings.Add(answer);

                Console.WriteLine("do you have another favorite thing? >>");

            } while (answer.ToLower()[0] == 'y')
            {
                Random rand = new Random();
                int index = rand.Next(0, favoriteThings.Count);

            }
        }
    }
}
