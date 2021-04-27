using System;
using System.Collections.Generic;
using System.Text;

namespace HW_7
{
    class Patient
    {
        public string FirstName { get; set; }
        public char MidInitial { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public bool FluVaccineYN { get; set; }
        public Dictionary<DateTime, double> Weights { get; set; }
        public List<string> AppoitmentHistory { get; set; }

        public Patient()
        {
            FirstName = string.Empty;
            MidInitial = '\0';
            LastName = string.Empty;
            ID = 0;
            FluVaccineYN = false;
            Weights = new Dictionary<DateTime, double>();
            AppoitmentHistory = new List<string>();
        }
        public Patient(int patID)
        {
            FirstName = string.Empty;
            MidInitial = '\0';
            LastName = string.Empty;
            ID = patID;
            FluVaccineYN = false;
            Weights = new Dictionary<DateTime, double>();
            AppoitmentHistory = new List<string>();
        }
        public Patient(string firstName, char midInit, string lastName)
        {
            FirstName = FirstName;
            MidInitial = midInit;
            LastName = lastName;
            ID = 0;
            FluVaccineYN = false;
            Weights = new Dictionary<DateTime, double>();
            AppoitmentHistory = new List<string>();
        }
        public override string ToString()
        {
            string output = $"{LastName}, {FirstName} {MidInitial}. ({ID}) Flu Vaccine:";

            if (FluVaccineYN)
            {
                output += " Yes";
            }
            else
            {
                output += " No";
            }
            return output;
        }
        public double CalculateMaxWeight()
        {
            double maxWeight = -50;

            foreach (double weight in Weights.Values)
            {
                if (maxWeight < weight)
                {
                    maxWeight = weight;
                }
            }

            return maxWeight;
        }
        public void DisplayApptHist()

        {
            foreach (string appoitment in AppoitmentHistory)
            {
                Console.WriteLine(appoitment);

            }
        }
        public void AdministerVaccine() //Assume Console.WriteLine();
        {
            if (FluVaccineYN)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Patient has already been administered the vaccine!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Patient has been administered the vacine!");
                Console.ForegroundColor = ConsoleColor.White;
                FluVaccineYN = true;

            }
        }
    }
}
