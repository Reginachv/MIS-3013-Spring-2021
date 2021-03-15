using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
              /*  Console.WriteLine("What is the profuct name of the item you are purchasing? >>");
            string productName = Console.ReadLine();

            Console.WriteLine("How many " + productName + "'s do you want to buy?");
            string totalUnits = Console.ReadLine();
            int numOfUnits = Convert.ToInt32(totalUnits);

            Console.WriteLine($"What is the price for each " + productName + "?");
            double price = Convert.ToDouble(Console.ReadLine());

            const double SALES_TAX = 0.085;

            double subtotal = numOfUnits * price;
            double salesTax = subtotal * SALES_TAX;
            double total = subtotal + salesTax;

            Console.WriteLine($"Your subtotal for your bill is: {subtotal.ToString("C2")}.");
            Console.WriteLine($"Your sales tax for your bill is: {salesTax.ToString("C2")}.");
            Console.WriteLine($"Your total for your bill is: {total.ToString("C2")}."); */

          //Part 2

            Console.WriteLine("What is your First Name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your Last Name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your student ID?");
            string studentID = Console.ReadLine();

            Console.WriteLine("what is your overall percentage for homework/");
            double homeworkGrade = Convert.ToDouble(Console.ReadLine()) / 100;
            

            Console.WriteLine(" What is your overall percentage grade for participation?");     
            double participationGrade = Convert.ToDouble(Console.ReadLine()) / 100;
            

            Console.WriteLine(" What is your overall percentage grade for quizzes?");
            double quizzesGrade = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine(" What is your overall percentage grade for midterm?");          
            double midtermGrade = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine(" What is your overall percentage grade for midterm?");
            double finalGrade = Convert.ToDouble(Console.ReadLine()) / 100;

            double participation = 0.08 * participationGrade;
            double homework = 0.12 * homeworkGrade;
            double midterm = 0.40 * midtermGrade;
            double final = 0.40 * finalGrade;

            double finaGrade = participation + homework + midterm + final;

            Console.WriteLine($"{ firstName} {lastName}, ({studentID}) your final grafe is {finalGrade.ToString("P2")}");
        }    
    }
}
