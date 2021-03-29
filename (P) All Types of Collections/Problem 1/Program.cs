using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine("\t Course 1 is " + courseSubject[0] + courseNumber[0]);
            Console.WriteLine("\t Course 2 is " + courseSubject[1] + courseNumber[1]);
            Console.WriteLine("\t Course 3 is " + courseSubject[2] + courseNumber[2]);

        }
    }
}
