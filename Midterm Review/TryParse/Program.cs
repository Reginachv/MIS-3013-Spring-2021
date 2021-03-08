using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age>>");
            string answer = Console.ReadLine();
            int age;
            // int age = Convert.ToInt32(answer);
            // Run into problems if user enters something that is not a
            //number since console cant convert it to integers

            if (int.TryParse(answer, out age) == true)
            {
                Console.WriteLine("good job entering number");
            }
            else
            {
                Console.WriteLine("Invalid number, Goodbye");
                Environment.Exit(-1);
            }
        }
    }
}
