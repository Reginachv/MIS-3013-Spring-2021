using System;
using System.Collections.Generic;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> courseGrades = new Dictionary<string, List<double>>();
            
            courseGrades.Add("MIS3013", new List<double>());
            courseGrades["MIS3013"].Add(0.95);

            List<double> MIS3033Grades = new List<double>();
            MIS3033Grades.Add(0.70);

            courseGrades.Add("MIS3033", MIS3033Grades);

            List<double> MIS3038Grades = new List<double>();
            MIS3038Grades.Add(0.80);

            courseGrades.Add("MIS3038", MIS3038Grades);

            foreach (string courseName in courseGrades.Keys)
            {
                List<double> grades = courseGrades[courseName];

                // Console.WriteLine(courseName);
                double sum = 0;
                foreach (double grade in grades)
                {
                    sum += grade;
                    Console.WriteLine($"{courseName} : {grade}");
                }
               // Console.WriteLine($"The average for {courseName} is [{sumgrades.ToString("P")}");

            }
           // double avg = 0;
           // double sum = 0;

           
                //sum = Convert.ToDouble(List.Sum(courseGrades));
                //avg = sum/3 
                // 3 course subjects
           
          //  Console.WriteLine($"The average for the 3 courses is {avg.Tostring("P2")}");
        }
    }
}
