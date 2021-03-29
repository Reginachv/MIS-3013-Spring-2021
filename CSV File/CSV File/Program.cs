using System;
using System.IO;

namespace CSV_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("sales_data_sample.csv");

            double totalfor2003 = 0;
            double totalfor2004 = 0;
            double totalfor2005 = 0;

            double[] monthlysales = new double[13]; // note ignoring the zero in array since months begin at 1
            monthlysales[1] = 0;
            monthlysales[2] = 0;
            monthlysales[3] = 0;
            monthlysales[4] = 0;
            monthlysales[5] = 0;
            monthlysales[6] = 0;
            monthlysales[7] = 0;
            monthlysales[8] = 0;
            monthlysales[9] = 0;
            monthlysales[10] = 0;
            monthlysales[11] = 0;
            monthlysales[12] = 0;

            for (int i = 1; i < lines.Length; i++)
            {

                //        0         1           2           3             4      5        6       7     8         9        10        11      12          13       14         15       16            17      18    19      20        21       22          23               24          25
                //ORDERNUMBER,QUANTITYORDERED,PRICEEACH,ORDERLINENUMBER,SALES,ORDERDATE,STATUS,QTR_ID,MONTH_ID,YEAR_ID,PRODUCTLINE,MSRP,PRODUCTCODE,CUSTOMERNAME,PHONE,ADDRESSLINE1,ADDRESSLINE2,CITY,STATE,POSTALCODE,COUNTRY,TERRITORY,CONTACTLASTNAME,CONTACTFIRSTNAME,DEALSIZE

                string line = lines[i];

                string[] pieces = line.Split(",");

                string status = pieces[6];
                int year = Convert.ToInt32(pieces[9]);
                int month = Convert.ToInt32(pieces[8]);
                double sales = Convert.ToDouble(pieces[4]);

                if (pieces[6].ToLower() == "shipped")
                {
                    switch (year)
                    {
                        case 2003:
                            totalfor2003 += sales;
                            break;

                        case 2004:
                            totalfor2004 += sales;
                            break;

                        case 2005:
                            totalfor2005 += sales;
                            break;
                        default:
                            break;
                    }
                    monthlysales[month] += sales;
                }
            }
            Console.WriteLine("Monthly sales total for shipped items over all three years are:");
            for (int i = 1; i < monthlysales.Length; i++)
            {

                if (i == 1)
                {
                    Console.WriteLine($"\n\tJanuary sales total: {monthlysales[i].ToString("C")}");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"\tFebruary sales total: {monthlysales[i].ToString("C")}");
                }
                else if (i == 3)
                {
                    Console.WriteLine($"\tMarch sales total: {monthlysales[i].ToString("C")}");
                }
                else if (i == 4)
                {
                    Console.WriteLine($"\tApril sales total: {monthlysales[i].ToString("C")}");
                }
                else if (i == 5)
                {
                    Console.WriteLine($"\tMay sales total: {monthlysales[i].ToString("C")}");
                }
                else if (i == 6)
                {
                    Console.WriteLine($"\tJune sales total: {monthlysales[i].ToString("C")}");
                }
                else if (i == 7)
                {
                    Console.WriteLine($"\tJuly sales total: {monthlysales[i].ToString("C")}");
                }
                else if (i == 8)
                {
                    Console.WriteLine($"\tAugust sales total: {monthlysales[i].ToString("C")}");
                }
                else if (i == 9)
                {
                    Console.WriteLine($"\tSeptember sales total: {monthlysales[i].ToString("C")}");
                }
                else if (i == 10)
                {
                    Console.WriteLine($"\tOctober sales total: {monthlysales[i].ToString("C")}");
                }
                else if (i == 11)
                {
                    Console.WriteLine($"\tNovember sales total: {monthlysales[i].ToString("C")}");
                }
                else // 12
                {
                    Console.WriteLine($"\tDecember sales total: {monthlysales[i].ToString("C")}");

                }
            }

            Console.WriteLine($"\nTotal sales for shipped items for 2003 is: {totalfor2003.ToString("C")}!");
            Console.WriteLine($"Total sales for shipped items for 2004 is: {totalfor2004.ToString("C")}!");
            Console.WriteLine($"Total sales for shipped items for 2005 is: {totalfor2005.ToString("C")}!");

        }
    }
}
   
