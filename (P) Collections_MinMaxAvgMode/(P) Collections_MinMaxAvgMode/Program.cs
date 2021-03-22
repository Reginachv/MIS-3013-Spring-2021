using System;
using System.Collections.Generic;

namespace _P__Collections_MinMaxAvgMode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> examGrades = new List<double>();
            Console.WriteLine("How many exam grades do you have?");
            int howManyExams = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < howManyExams; i++)
            {
                Console.WriteLine("Name the Exam name");
                String examName = new string(Console.ReadLine());
            }

            for (int i = 0; i < howManyExams; i++)
            {
                Console.WriteLine("What is your exam grade?");
                string answer = Console.ReadLine();
                double grade;

                if (double.TryParse(answer, out grade) == false)
                {
                    Console.WriteLine("invalid exam grade");
                }         
                else
                {
                   
                }

                Console.WriteLine();
                
                //min;max;avg;mode




            }
        }
    }
}

 

