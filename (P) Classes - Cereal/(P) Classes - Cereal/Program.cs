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


                //Console.WriteLine(Has a serivng size of 1 or more cups);
                //I attempted to have this not repeat but it just kept seperating by brands ending up just changing color to green for those with calories less than 100
                if (Convert.ToDouble(c.Cups) >= 1)
                {

                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{c.Name}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();

                    if (Convert.ToDouble(c.Calories) <= 100)
                    { 
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\t has less than 100 calories");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("\t"); // just to match reset of format
                    }
                    
                    Console.Write(c.ToString());
                }
            }
        }
            }
        }
    

