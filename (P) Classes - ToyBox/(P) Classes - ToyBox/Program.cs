using System;
using System.Collections.Generic;

namespace _P__Classes___ToyBox
{
    class Program
    {
        public static object Manufacturer { get; private set; }

        static void Main(string[] args)
        {
            List<string> Manufacturer = new List<string>();
            List<string> Name = new List<string>();
            List<double> Price = new List<double>();
            List<string> Notes = new List<string>();

            Console.WriteLine("Please enter how many toys you have");
            int NumberofToys = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < NumberofToys; i++)
           {
               // Toy[] toy = new Toy[i];

                Console.WriteLine($"Please enter the manufacturer of toy # {i}", i);
                Manufacturer.Add(Console.ReadLine());

                Console.WriteLine($"Please enter the Name of toy # {i}", i);
                Name.Add(Console.ReadLine());

                Console.WriteLine($"Please enter the price toy #{i}", i);
                Price.Add(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine($"Enter any extra information about you toy #{i}", i);
                Notes.Add(Console.ReadLine());
            }


        }
    }
}
