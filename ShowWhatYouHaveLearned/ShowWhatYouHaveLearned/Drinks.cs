using System;
using System.Collections.Generic;
using System.Text;

namespace ShowWhatYouHaveLearned
{
    class Drinks
    {
        public string Type { get; set;}
        public string Name { get; set; }
        public double Price { get; set; }

        public Drinks()
        {
            Type = string.Empty;
            Name = " ";
            Price = 0; 
        }
        public Drinks(string type, string name, double price)
        {
            this.Type = type;
            this.Name = name;
            this.Price = Price;
        }
        public override string ToString()
        {
            
            return $"You ordered a {Name} drink type: {Type}, for ${Price} from Starbucks - NOT including Sales Tax !!";
        }
    }
}
