using System;
using System.Collections.Generic;

namespace HW_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many patients do you have?");
            int AmountofPatients = Convert.ToInt32(Console.ReadLine());

            List<string> PatientInfo = new List<string>();
            int[] patients = new int[AmountofPatients];

            for (int i = 1; i < AmountofPatients; i++)
            {
                Console.WriteLine($"What is the First Name of Patient? {i}");
                string FirstName = Console.ReadLine();
                
                Console.WriteLine($"What is the Last Name of Patient? {i}");
                string LastName = Console.ReadLine();

                Console.WriteLine($"What is the ID of Patient?");
                int ID = Convert.ToInt32(Console.ReadLine());

               /* Console.WriteLine($"What are all the known weights for patient {i} (e.g. 194, 182.0, 133.43)");
                string weights = Console.ReadLine();

                string[] weightSplit = weights.Split(',');
                double allWeights = Convert.ToDouble(weightSplit); */


                //PatientInfo.Add(FirstName + LastName + ID) ;

                Console.WriteLine($"{LastName}, {FirstName}");
            }    
        }
    }
}
