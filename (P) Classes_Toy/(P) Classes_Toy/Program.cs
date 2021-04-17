using System;

namespace _P__Classes_Toy
{
    class Program
    {
        public class Toy
        {
            public string Manufacturer { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            private string Notes { get; set; }
            

            public Toy()
            {
                Manufacturer = " "; 
                Name = " "; 
                Price = 0; 
                Notes = " ";
               //Notes : Extra Info about Toy
            }
            public Toy(string manufacturer, string name, double price, string notes )
            {
                this.Manufacturer = manufacturer;
                this.Name = name;
                this.Price = price;
                this.Notes = notes;
            }
            public String GetAisle()
              {
                
                string Manu;
               
                Manu = Manufacturer.Substring(0, 1).ToUpper();
                Random rand = new Random();
                int randomNumber= rand.Next(1, 25);

                string result = Manu + randomNumber;

                return result;
              }  
            public void AllToy() 
            {
                Console.WriteLine("\n Manufacturer: " + Manufacturer + "\n Toy Name: " + Name + "\n Price: $" + Price + "\n Notes: " + Notes); // can take out "Notes:" for cleaner look
            }
           
            static void Main(string[] args) //Main Method
            {
                

                Toy[] toy = new Toy[3]; //Collection holds all information for each toy to display to user 
                toy[0] = new Toy();
                toy[0].setManufacturer("Nintendo");
                toy[0].setName("Nintendo Switch");
                toy[0].setPrice(269.99);
                toy[0].setNotes("Available in colors: red, black, and gray and limited edition for collectors"); 

                toy[1] = new Toy();
                toy[1].setManufacturer("MGA Entertainment");
                toy[1].setName("Bratz Dolls");
                toy[1].setPrice(29.54);
                toy[1].setNotes("Available dolls are: Yasmin, Cloe, Sasha, and Jade ACCESSORIES NOT INCLUDED!!!"); 

                toy[2] = new Toy();
                toy[2].setManufacturer("US General");
                toy[2].setName("Workbench");
                toy[2].setPrice(19.99);
                toy[2].setNotes("Kid's can set up and play with this toy workbench that has realistic drill press action"); //more of a descriptive note got off walmart >.< 
               
                Console.WriteLine("Toy's available:");
                for (int i = 0; i < toy.Length; i ++)
                {
                    toy[i].AllToy();
                }
                
            }

            private void setNotes(string Notes) //suggested by question mark => in order to set information in array
            {
                this.Notes = Notes;
            }

            private void setPrice(double Price)
            {
                this.Price = Price;
            }

            public void setName(string Name)
            {
                this.Name = Name;
            }

            private void setManufacturer(string Manufacturer)
            {
                this.Manufacturer = Manufacturer;
            }
        }
    }
}

