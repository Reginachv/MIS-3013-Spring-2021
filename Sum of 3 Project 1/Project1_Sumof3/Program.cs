using System;

namespace Project1_Sumof3
{
    class Program
    {
            static int sum(int num1, int num2, int num3)
            {
                int total;
                total = num1 + num2 + num3;
                return total;
            }

            static void Main(string[] args)
           {
                Console.WriteLine("\n\nFunction to Calculate the sum of three numbers :\n");
            Console.WriteLine("---------------------------\n");
                Console.WriteLine("Enter number 1");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 2");
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 3");
                int n3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nThe sum of three numbers is : {0:F3} \n", sum(n1, n2, n3));
      
{ 
                
            }
        }
    }
}








