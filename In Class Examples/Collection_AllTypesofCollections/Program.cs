using System;
using System.Collections.Generic;

namespace Collection_AllTypesofCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            string[] courseSubject = new string[3];
           int[] courseNumber = new int[3];


            Console.WriteLine("Please enter 3 Course Subjects (1 per line)");
            for (int i = 0; i < 3; i++)
            {
                courseSubject[i] = Console.ReadLine();
            }
            //Console.WriteLine("\t For course 1 you entered " + courseSubject[0]);
            //Console.WriteLine("\t For course 2 you entered " + courseSubject[1]);
           // Console.WriteLine("\t For course 3 you entered " + courseSubject[2]);

            Console.WriteLine("Please enter 3 Course Numbers for each subject (1 per line)");
            for (int i = 0; i < 3; i++)
            {
                courseNumber[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Console.WriteLine("\t For course 1 you entered " + courseNumber[0]);
            //Console.WriteLine("\t For course 2 you entered " + courseNumber[1]);
            //Console.WriteLine("\t For course 3 you entered " + courseNumber[2]);

            Console.WriteLine("\t Course 1 is " + courseSubject[0]+courseNumber[0]);
            Console.WriteLine("\t Course 2 is " + courseSubject[1]+courseNumber[1]);
            Console.WriteLine("\t Course 3 is " + courseSubject[2]+courseNumber[2]);

        }

            //Problem 2
           /* 
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
           */

            //Problem 3
            /*
            Dictionary<string, List<double>> courseGrades = new Dictionary<string, List<double>>();
            courseGrades.Add("MIS3013", new List<double>());
            courseGrades["MIS3013"].Add(0.95);

            List<double> MIS3033Grades = new List<double>();
            MIS3033Grades.Add(0.70);

            courseGrades.Add("MIS3033", MIS3033Grades);

            foreach (string courseName in courseGrades.Keys)
            {
               // List<double> ;
            } */


        }
    }

