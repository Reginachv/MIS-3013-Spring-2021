using System;
using System.Collections.Generic;

namespace Collection__P__Max_Min__Average__Mode
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            List<double> examScores = new List<double>();
            Dictionary<double, int> exams = new Dictionary<double, int>();

            Console.WriteLine("How Many exams?");
            int numberofExams = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Enter your exam score: >>");
                answer = Console.ReadLine();

                double score = Convert.ToDouble(answer); //assuming the user knows what they are doing so no TryParse
                examScores.Add(score); //store the value

                Console.WriteLine("do you have another exam grade, yes or no?>>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');

            double min = examScores[0];
            double max = examScores[0];

            foreach (double score in examScores)
            {
                if (score < min)
                {
                    min = score;
                }
                if (score > max)
                {
                    max = score;
                }
                    if (exams.ContainsKey(score) == true)
                {
                    exams[score] = exams[score] + 1;
                }
                else
                {
                    exams.Add(score, 1);
                }
            }
            
            double sum = 0;
            double avg = 0;

           foreach (double score in examScores)
            {
                sum += score;
                avg = sum / numberofExams;
                //avg = sum/examScores.Count;
            }

            Console.WriteLine($"The average of exam score is: {avg.ToString("N2")}");
            Console.WriteLine($"the minimum exam score is: {min.ToString("N2")}");
            Console.WriteLine($"the minimum exam score is: {max.ToString("N2")}");
            int highestOccurence = 0;
            foreach (double scoreKey in exams.Keys)
            {
                if (exams[scoreKey] > highestOccurence)
                {
                    highestOccurence = exams[scoreKey];
                }
            }
            foreach (double scorekey in exams.Keys)
            {
                if (exams[scorekey] == highestOccurence)
                {
                    Console.WriteLine($"{scorekey} occurs the most.");
                }
            }
        }
    }
}