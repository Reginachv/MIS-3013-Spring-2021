using System;
using System.Collections.Generic;

namespace InClassExample_P.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            List<double> examScores = new List<double>();

            do
            {
                Console.WriteLine("enter your exam score: >>");
                answer = Console.ReadLine();

                double score = Convert.ToDouble(answer); //assuming the user knows what they are doing so no TryParse
                examScores.Add(score); //store the value

                Console.WriteLine("do you have another exam grade, yes or no?");
                answer = Console.ReadLine();


            }
            while (answer.ToLower()[0] == 'y');

            double min = examScores[0];
            
            foreach (double score in examScores)
            {
                if (score < min)
                {
                    min = score;
                }
            }
            //Console.WriteLine($"average of exam score is: {average.ToString("N2")});
            Console.WriteLine($"the minimum exam score is: {min.ToString("N2")}"); 

            /*
            Dictionary<double> examScores = new Dictionary<double>();
            string answer;
            do
            {
                Console.WriteLine("enter your exam score: >>");
                answer = Console.ReadLine();

                double score = Convert.ToDouble(answer); //assuming the user knows what they are doing so no TryParse
                examScores.Add(score); //store the value

                Console.WriteLine("do you have another exam grade, yes or no?");
                answer = Console.ReadLine();


            }
            while (answer.ToLower()[0] == 'y');

            double min = examScores[0];

            foreach (double score in examScores)
            {
                if (score < min)
                {
                    min = score;
                }
                if (examScores.ContainsKey(score) == true)
                {
                    examScores = exams[score] + 1;
                }
                exams.Add(score, 1);
            }
            //Console.WriteLine($"average of exam score is: {average.ToString("N2")});
            Console.WriteLine($"the minimum exam score is: {min.ToString("N2")}");

            int mode = 0;
            foreach (double[scoreKey > mode)
            {
                mode = exams[scoresKey];*/
            }

        }
    }

