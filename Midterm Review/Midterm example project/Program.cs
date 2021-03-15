using System;

namespace Midterm_example_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the product name of the item you are purchasing?");
            string productName = Console.ReadLine();

            Console.WriteLine("How many " + productName + "'s do yo wish to buy?");
            string numberOfUnits = Console.ReadLine();
            int Units = Convert.ToInt32(numberOfUnits);

            Console.WriteLine("What is the price for each" + productName + "?");
        }
    }
}
