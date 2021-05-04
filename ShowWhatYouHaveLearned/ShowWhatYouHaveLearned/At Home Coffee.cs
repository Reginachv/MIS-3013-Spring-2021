using System;
using System.Collections.Generic;
using System.Text;

namespace ShowWhatYouHaveLearned
{
    class At_Home_Coffee
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public At_Home_Coffee()
        {
            Type = string.Empty;
            Name = " ";
            Price = 0;
        }
        public At_Home_Coffee(string type, string name, double price)
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
