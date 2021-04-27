using System;
using System.Collections.Generic;
using System.IO;

namespace _P__Classes___Cereal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Cereal_Data.txt");

            //line[0] = "name|manufacturer|calories|cups"

            List<Cereal> bowls = new List<Cereal>();



            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                string[] cerealInfo = line.Split('|');

                string name = cerealInfo[0];
                Cereal c = new Cereal();
                c.Name = name;
                c.Manufacturer = cerealInfo[1];
                c.Calories = Convert.ToDouble(cerealInfo[2]);
                c.Cups = Convert.ToDouble(cerealInfo[3]);


                if (Convert.ToDouble(c.Cups) >= 1)
                {
                        Console.WriteLine(c.ToString()); 
                    
                }
            }
            
           

                /*List<string> Manufacturers = new List<string>();
                List<string> Names = new List<string>();
                List<double> Calories = new List<double>();
                List<double> Cups = new List<double>();


                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];

                    string[] pieces = line.Split('|');

                    string Manufacturer = pieces[2];
                    string Name = pieces[2];

                    string CaloriesAsString = pieces[3];
                    double Calorie = Convert.ToDouble(CaloriesAsString);

                    string CupsAsString = pieces[4];
                    double Cup = Convert.ToDouble(CupsAsString);

                    Manufacturers.Add(Manufacturer);
                    Names.Add(Name);
                    Calories.Add(Calorie);



                    if (Cup > 1)
                    {

                        Console.WriteLine($"{Manufacturers}, {Name}, {Calories}, {Cups}"); 
                     }*/

            }
        }
    }

