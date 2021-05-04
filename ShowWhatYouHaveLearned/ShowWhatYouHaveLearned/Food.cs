using System;
using System.Collections.Generic;
using System.Text;

namespace ShowWhatYouHaveLearned
{
    class Food
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Food()
        {
            Type = string.Empty;
            Name = " ";
            Price = 0;
        }
        public Food(string type, string name, double price)
        {
            this.Type = type;
            this.Name = name;
            this.Price = Price;
        }
        public override string ToString()
        {
            return $"You orders a {Type}: {Name}, {Price} NOT including Sales Tax from Starbucks!!";

        }
    }
}
