using System;
using System.Collections.Generic;

namespace HW_6
{
    class Program
    {
        const double TAX_RATE = 0.085;
        static void Main(string[] args)
        {
            List<string> orderHistory = new List<string>();
            double total = 0;

            string answer;
            do
            {
                string menu = GetMenu();
                Console.WriteLine(menu);
                Console.WriteLine("\nWhat would you like to order? >>");
                answer = Console.ReadLine();
                orderHistory.Add(answer);

                double price = CalculatePrice(answer);
                total += price;
                ShowReceipt(price);

                Console.WriteLine("Would you like to order anything else yes or no >>");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");

            Console.WriteLine("\n You ordered:");
            bool isFirstTime = true;

            foreach (string item in orderHistory)
            {
                if (isFirstTime)
                {
                    Console.WriteLine(item);
                    isFirstTime = false;
                }
                else
                {
                    Console.WriteLine(item + ",");
                }
            }
                Console.WriteLine();
                Console.Write($"({orderHistory.Count} drinks!)That is a total of");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($" {total.ToString("C")}!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" worth of coffee!!");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\nThank you for playing!");
                Console.ForegroundColor = ConsoleColor.White;
            }

    static string GetMenu()
    {
        /* string msg = "\tCoffee Shop Menu \n Fresh Coffee ----- $2.25\n Café au lait -----$3.72\n Latte ----$4.03\n Hot Choclate ---- $3.51 \n Pumpkin Spice -----$7.30";
         return msg; */

        string msg = "           Coffee Shop Menu         " +
                     "  \n   Fresh Coffee ------ $2.25    " +
                     "  \n    Café au lait------ $3.72    " +
                     "   \n          Latte ------ $4.03    " +
                     "  \n  Hot Chocolate ------ $3.51    " +
                     "  \n  Pumpkin Spice ------ $7.30    ";
        return msg;
    }
    static double CalculatePrice(string item)
    {
        double result;
        switch (item)
        {
            case "Fresh Coffee":
                result = 2.25;
                break;
            case "Cafe au lait": //accent could have been included - Café au lait 
                result = 3.72;
                break;
            case "Latte":
                result = 4.03;
                break;
            case "Hot Chocolate":
                result = 3.51;
                break;
            case "Pumpkin Spice":
                result = 7.30;
                break;
            default:
                result = 0;
                break;
        }
        return result;
    }
    static void ShowReceipt(double subTotal)
    {
        double tax = subTotal * TAX_RATE;
        double total = subTotal + tax;
        Console.Write($"Subtotal for your drink(s) is");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($" {subTotal.ToString("C")}");
        Console.ForegroundColor = ConsoleColor.White;

        Console.Write($".  Tax for your drink(s) is");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($" {tax.ToString("C")}");
        Console.ForegroundColor = ConsoleColor.White;

        Console.Write($" Total your drink(s) is");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($" {total.ToString("C")}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        }
    }
}
