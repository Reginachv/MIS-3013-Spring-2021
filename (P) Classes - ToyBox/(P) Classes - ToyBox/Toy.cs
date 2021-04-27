using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Classes___ToyBox
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
        public Toy(string manufacturer, string name, double price, string notes)
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
            int randomNumber = rand.Next(1, 25);

            string result = Manu + randomNumber;

            return result;
        }
        static void Main(string[] args) //Main Method
        {

            Console.WriteLine("Please enter how many toys you have");
            int NumberofToys = Convert.ToInt32(Console.ReadLine());

            List<string> Manufacturer = new List<string>();
            List<string> Name = new List<string>();
            List<double> Price = new List<double>();
            List<string> Notes = new List<string>();


            for (int i = 1; i < NumberofToys ; i++)
            {
                //Toy[] toy = new Toy[i];
                Console.WriteLine($"Please enter the manufacturer of toy # {i}");
                Manufacturer.Add(Console.ReadLine());

                Console.WriteLine($"Please enter the Name of toy # {i}");
                Name.Add(Console.ReadLine());

                Console.WriteLine($"Please enter the price toy #{i}");
                Price.Add(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine($"Enter any extra information about you toy #{i}");
                Notes.Add(Console.ReadLine());

            }
            for (int i = 0; i < NumberofToys; i++)
            {
                Console.WriteLine($"\n Manufacturer: {Manufacturer} \nToy Name: {Name} \nPrice: ${Price} \n Notes: {Notes}");
            }

            Console.WriteLine("How many 'toy boxes' do you need for your toys?");
            int NumberofToyBoxes = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"{Name}");

            for(int i = 1; i < NumberofToyBoxes; i++)
            {
                Console.WriteLine($"What goes into box one? {i}");

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
//just another way
   /*public class Toy
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Notes;


        public Toy()
        {
            Manufacturer = getManufacucturer();
            Name = "";
            Price = 0;
            Notes = string.Empty;
        }

        public Toy(string notes)// : this()
        {
            Manufacturer = string.Empty;
            Name = "";
            Price = 0;
            Notes = notes;
        }

        public void AddNote(string note)
        {
            Notes += "\n" + note;
        }

        public string GetNotes()
        {
            return Notes;
        }

        public string GetAisle()
        {
            string aisle = "";
            Random rand = new Random();

            aisle = "" + Manufacturer.ToUpper()[0] + rand.Next(1, 25);

            return aisle;
        }

        public override string ToString()
        {
            return $"{Name} manufactured by {Manufacturer} for {Price.ToString("C")} can be found on Aisle {GetAisle()}. {GetNotes()}";
        }
    }
}
   */