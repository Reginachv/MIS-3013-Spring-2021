using System;
using System.Collections.Generic;

namespace Collection_AllTypesofCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1

            //Problem 2

            //Problem 3

            Dictionary<string, List<double>> courseGrades = new Dictionary<string, List<double>>();
            courseGrades.Add("MIS3013", new List<double>());
            courseGrades["MIS3013"].Add(0.95);

            List<double> MIS3033Grades = new List<double>();
            MIS3033Grades.Add(0.70);

            courseGrades.Add("MIS3033", MIS3033Grades);

            foreach (string courseName in courseGrades.Keys)
            {
                List<double> ;
            }


        }
    }
}
