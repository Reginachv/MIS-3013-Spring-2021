using System;

namespace InClassEx_Conversions_Feb1
{
    class Program
    {
        static void Main(string[] args)
        {
            int heresMyInt;
            double heresMyDouble;



            heresMyDouble = 5.5;
            heresMyInt = 5;

            double result = heresMyDouble + heresMyInt;

            //Console.WriteLine("The result of" + heresMyDouble.ToString("N3") + " + " +
            //    heresMyInt.ToString + " = " + result.ToString("C5"));

            Console.WriteLine($"The result of {heresMyDouble.ToString("N3")} + {heresMyInt.ToString()} = {result.ToString("C5")}.)");
        }
    }
}
