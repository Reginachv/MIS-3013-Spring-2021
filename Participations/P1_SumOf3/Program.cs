using System;

namespace P1_SumOf3
{
    class Program
    {
        static double ClassLevelVariable = 5;
        static void Main(string[] args)
        {
           const double MAGIC_NUMBER = 7.777; // local variable that is a constant 

            // Can't do this because it is a constant value MAGIC_NUMBER = 8;
            ClassLevelVariable = 8;

        }
    }
}
