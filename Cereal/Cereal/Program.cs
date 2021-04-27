using System;
using System.Collections.Generic;
using System.IO;

namespace Cereal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Cereal_Data.txt");

            List<string> Manufacturers = new List<string>();
            List<string> Names = new List<string>();
            List<double> Calories = new List<double>();
            List<double> Cups = new List<double>();


            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                string[] pieces = line.Split('|');

                string Manufacturer = pieces[2];
                string Name = pieces[2];

              /*  string CaloriesAsString = pieces[3];
                double Calorie = Convert.ToDouble(CaloriesAsString);

                string CupsAsString = pieces[4];
                double Cup = Convert.ToDouble(CupsAsString); */

                Manufacturers.Add(Manufacturer);
                Names.Add(Name);
                //Calories.Add(Calorie);


                Console.WriteLine($"{Manufacturers}, {Names}");
               /* if (Cup > 1)
                {

                    Console.WriteLine($"{Manufacturers}, {Name}, {Calories}, {Cups}");
                } */
            }
        }
    }
}
    

