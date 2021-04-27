using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _P__Classes___Cereal
{
    class Cereal
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Cups { get; set; }

        public Cereal()
        {
            Manufacturer = string.Empty;
            Name = " ";
            Calories = 0;
            Cups = 0;
             
        }
        public override string ToString()
        {
            return $"\n{Name} made by {Manufacturer} has {Calories} Calories and {Cups} cups.";
        }
    }
}
