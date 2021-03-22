using System;
using System.Collections.Generic;
using System.Linq;

namespace _P__Collections_MinMaxAvgMode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> examGrades = new List<double>();
            Dictionary<double, int> exams = new Dictionary<double, int>();
            Console.WriteLine("How many exam grades do you have?");
            int howManyExams = Convert.ToInt32(Console.ReadLine());
            string answer;

            /*  for (int i = 0; i < howManyExams; i++)
              {
                  Console.WriteLine("Name the Exam name");
                  String examName = new string(Console.ReadLine());
              }*/

            for (int i = 0; i < howManyExams; i++)
            {
            
                    Console.WriteLine("What is your exam grade? (e.g. 92)");
                    answer = Console.ReadLine();

                    double grade = Convert.ToDouble(answer);
                 
               }

            answer = Console.ReadLine();
            double min = examGrades[0];

            foreach (double grade in examGrades)
            {
                if (grade < min)
                {
                    min = grade;
                }
                if (exams.ContainsKey(grade) == true)
                {
                    exams[grade] = exams[grade] + 1;
                }
                else
                {
                    exams.Add(grade, 1);
                }
            }

            Console.WriteLine($"The minimimum exam grade is {min.ToString("N2")}");

                }
            }
        }
    

 

