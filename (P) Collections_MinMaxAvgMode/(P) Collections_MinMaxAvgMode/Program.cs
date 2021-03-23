using System;
using System.Collections.Generic;
using System.Linq;

namespace _P__Collections_MinMaxAvgMode
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<double> examGrades = new List<double>();

            Dictionary<string, List<double>> Exams = new Dictionary<string, List<double>>();
            Console.WriteLine("How many exam grades do you have?");
            int howManyExams = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < howManyExams; i++)
            {
                Console.WriteLine("What is the subject of Exam {0}:", i);
                var examName = Console.ReadLine();
                Exams.Add(examName, new List<double>());
                for (int test = 0; test < howManyExams; test++)
                {
                    Console.WriteLine("Enter exam score {0} for " + "examName{1}: ", test, examName);
                    Exams[examName].Add(Convert.ToDouble(Console.ReadLine()));
                }
            }
        }
    }
}
      







