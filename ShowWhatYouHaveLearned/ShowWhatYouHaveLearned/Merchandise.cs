using System;
using System.Collections.Generic;
using System.Text;

namespace ShowWhatYouHaveLearned
{
    class Merchandise
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Merchandise()
        {
            Type = string.Empty;
            Name = " ";
            Price = 0;
        }
        public Merchandise(string type, string name, double price)
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
