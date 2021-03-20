using System;
using System.Collections.Generic;

namespace _P__Collections_MinMaxAvgMode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> examGrades = new List<double>();
            string answer;

            do
            {
                Console.WriteLine("What are your Exam Grades?");
                answer = Console.ReadLine();
                double grade = Convert.ToDouble(answer);

                if (double.TryParse(answer, out grade) == false)
                {
                    Console.WriteLine("invalid number");
                }
                else
                {

                }

                examGrades.Add(grade);

                Console.WriteLine("Do you have another Exam Grade?");
                answer = Console.ReadLine();
                Convert.ToDouble(answer);
            } 
           
      
            {

            }
               
        }
    }
}
