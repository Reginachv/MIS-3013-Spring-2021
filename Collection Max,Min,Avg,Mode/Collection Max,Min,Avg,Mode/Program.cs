using System;

namespace Collection_Max_Min_Avg_Mode
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalExams = 0;
          
            Console.WriteLine("Enter the number of exams.");
            TotalExams = Convert.ToInt32(Console.ReadLine());

            int[] scoresArray = new int[TotalExams];

            for (int i = 0; i < TotalExams; i++)
            {
                Console.WriteLine("Enter exam name {0}", TotalExams);
                var name = Console.ReadLine();
                Console.WriteLine("Please enter exam score {1}", i + 1);
                scoresArray[i] = Convert.ToDouble(Console.ReadLine());
                    {

                }
            }
        }
    }
}
