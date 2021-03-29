using System;
using System.Collections.Generic;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            List<double> grades = new List<double>();

            do
            {
                Console.WriteLine("Enter your exam score: >>");
                answer = Console.ReadLine();

                double score = Convert.ToDouble(answer); //assuming the user knows what they are doing so no TryParse
                grades.Add(score); //store the value

                Console.WriteLine("do you have another exam grade, yes or no?>>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');

            double sum = 0;
            double avg = 0;
            foreach (double score in grades)
            {
                sum += score;
                avg = sum / grades.Count;
            }
            Console.WriteLine($"The average of the grades is {avg.ToString("N2")}");
        }
    }
}
