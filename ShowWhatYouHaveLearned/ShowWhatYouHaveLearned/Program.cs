using System;
using System.Collections.Generic;
using System.IO;

namespace ShowWhatYouHaveLearned
{
    class Program
    {
        static void Main(string[] args)
        {
           // const double SALES_TAX = 0.085; // Could have done this but my code is already very long :(

            string[] lines = File.ReadAllLines("menu.csv");

            Console.WriteLine("StarBucks Menu \n");

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(",");

                string type = pieces[0];

                Console.WriteLine(type);
            }

                Console.WriteLine("\nWhich one would you like to access?");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "drinks")
                {
                        for (int i = 1; i < lines.Length; i++)
                        {
                        }
                        string line = lines[1];
                        string[] pieces = line.Split(",");
                        Console.WriteLine($"\n{pieces[2]}\n{pieces[3]}\n{pieces[4]} \n{pieces[5]}\n{pieces[6]}\n{pieces[7]}");

                        Console.WriteLine($"\n What type of drink?");
                        string drink = Console.ReadLine();

                if (drink.ToUpper() == "HOT TEAS")
                {
                    Console.WriteLine($"What is the name of the {drink} drink");
                    string order = Console.ReadLine();

                    Drinks drink1 = new Drinks();
                    drink1.Type = drink;
                    drink1.Name = order;
                    drink1.Price = 2.75;
                    //Could have asked or input for price WORKS!
                    /*Console.WriteLine($"What is the price of the {order}?");
                    string HTprice = Console.ReadLine();
                    double drinkprice = Convert.ToDouble(HTprice);
                    if (Double.TryParse(HTprice, out drinkprice))
                    {
                        drink1.Price = drinkprice;
                    }
                    else
                    {
                        Console.WriteLine("Not an valid number!");
                    }*/

                    Console.WriteLine(drink1.ToString());


                }
                else if (drink.ToUpper() == "HOT DRINKS") 
                {
                    Console.WriteLine($"What is the name of the {drink} drink");
                    string order = Console.ReadLine();


                    Drinks drink1 = new Drinks();
                    drink1.Type = drink;
                    drink1.Name = order;
                    drink1.Price = 2.75;
                    Console.WriteLine(drink1.ToString());

                }
                else if (drink.ToUpper() == "FRAPPUCCHINO BLEND")
                {
                    Console.WriteLine($"What is the name of the {drink} drink");
                    string order = Console.ReadLine();


                    Drinks drink1 = new Drinks();
                    drink1.Type = drink;
                    drink1.Name = order;
                    drink1.Price = 2.75;
                    Console.WriteLine(drink1.ToString());
                }
                else if (drink.ToUpper() == "COLD COFFEES")
                {
                    Console.WriteLine($"What is the name of the {drink} drink");
                    string order = Console.ReadLine();

                    Drinks drink1 = new Drinks();
                    drink1.Type = drink;
                    drink1.Name = order;
                    drink1.Price = 4.25;

                    
                    Console.WriteLine(drink1.ToString());
                }
                else if (drink.ToUpper() == "ICED TEAS")
                {
                    Console.WriteLine($"What is the name of the {drink} drink");
                    string order = Console.ReadLine();


                    Drinks drink1 = new Drinks();
                    drink1.Type = drink;
                    drink1.Name = order;
                    drink1.Price = 3.25;

                    Console.WriteLine(drink1.ToString());
                }
                else if (drink.ToUpper() == "COLD DRINK")
                {
                    Console.WriteLine($"What is the name of the {drink} drink");
                    string order = Console.ReadLine();


                    Drinks drink1 = new Drinks();
                    drink1.Type = drink;
                    drink1.Name = order;
                    drink1.Price = 5.25;

                    Console.WriteLine(drink1.ToString());
                }
                else
                {
                    Console.WriteLine("Sorry that is not in our menu!!");  
                }
                         
            }
                else if (answer.ToLower() == "food")
                {
                    for (int i = 1; i < lines.Length; i++)
                    {
                    }
                    string line = lines[2];
                    string[] pieces = line.Split(",");
                    Console.WriteLine($"\n{pieces[2]}\n{pieces[3]}\n{pieces[4]} \n{pieces[5]}");

                    Console.WriteLine($"\n What type of food?");
                    string food = Console.ReadLine();

                if (food.ToUpper() == "HOT BREAKFAST")
                {
                    Console.WriteLine($"What is the name of the {food} drink");
                    string order = Console.ReadLine();

                    Drinks food1 = new Drinks();
                    food1.Type = food;
                    food1.Name = order;
                    food1.Price = 4.95;

                    Console.WriteLine(food1.ToString());
                }
                else if (food.ToUpper() == "BAKERY")
                {
                    Console.WriteLine($"What is the name of the {food} drink");
                    string order = Console.ReadLine();

                    Drinks food1 = new Drinks();
                    food1.Type = food;
                    food1.Name = order;
                    food1.Price = 1.95;


                    Console.WriteLine(food1.ToString());
                }
                else if (food.ToUpper() == "LUNCH")
                {
                    Console.WriteLine($"What is the name of the {food} drink");
                    string order = Console.ReadLine();

                    Drinks food1 = new Drinks();
                    food1.Type = food;
                    food1.Name = order;
                    food1.Price = 5.95;


                    Console.WriteLine(food1.ToString());
                }
                else if (food.ToUpper() == "SNACKS & SWEETS ")
                {
                    Console.WriteLine($"What is the name of the {food} drink");
                    string order = Console.ReadLine();

                    Drinks food1 = new Drinks();
                    food1.Type = food;
                    food1.Name = order;
                    food1.Price = 2.75;

                    Console.WriteLine(food1.ToString());
                }
                else if (food.ToUpper() == " OATMEAL & YOGURT")
                {
                    Console.WriteLine($"What is the name of the {food} drink");
                    string order = Console.ReadLine();

                    Drinks food1 = new Drinks();
                    food1.Type = food;
                    food1.Name = order;
                    food1.Price = 3.75;


                    Console.WriteLine(food1.ToString());
                }
                else
                {
                    Console.WriteLine("Sorry item not in our menu!!");
                }

            }
                else if (answer.ToLower() == "at home coffee")
                {
                    for (int i = 1; i < lines.Length; i++)
                    {
                    }
                    string line = lines[3];
                    string[] pieces = line.Split(",");
                    Console.WriteLine($"\n{pieces[2]}\n{pieces[3]}");

                        Console.WriteLine($"\n What type of at {answer}?");
                        string other = Console.ReadLine();

                        if (other.ToUpper() == "WHOLE BEAN")
                         {
                            Console.WriteLine($"What is the name of the {other} drink");
                            string order = Console.ReadLine();

                             At_Home_Coffee home1 = new At_Home_Coffee();
                            home1.Type = other;
                            home1.Name = order;
                            home1.Price = 18.00;


                            Console.WriteLine(home1.ToString());
                }
                        else if (other.ToUpper() == "VIA INSTANT")
                        {
                            Console.WriteLine($"What is the name of the {other} drink");
                            string order = Console.ReadLine();

                            At_Home_Coffee home1 = new At_Home_Coffee();
                            home1.Type = other;
                            home1.Name = order;
                            home1.Price = 9.95;
                          Console.WriteLine(home1.ToString());
                }
                        else
                        {
                            Console.WriteLine("Sorry item not in our menu!!");
                        }

            }
                else if( answer.ToLower() == "merchandise")
                {
                    for (int i = 1; i < lines.Length; i++)
                    {
                    }
                    string line = lines[4];
                    string[] pieces = line.Split(",");
                    Console.WriteLine($"\n{pieces[2]}\n{pieces[3]}\n{pieces[4]}");

                Console.WriteLine($"\n What type of {answer}?");
                string merchandise = Console.ReadLine();

                if (merchandise.ToUpper() == "COLD CUPS")
                {
                    Console.WriteLine($"What is the name of the {merchandise} drink");
                    string order = Console.ReadLine();

                    Merchandise merch1 = new Merchandise();
                    merch1.Type = merchandise;
                    merch1.Name = order;
                    merch1.Price = 4.95;

                    Console.WriteLine(merch1.ToString());

                }
                else if (merchandise.ToUpper() == "TUMBLERS")
                {
                    Console.WriteLine($"What is the name of the {merchandise} drink");
                    string order = Console.ReadLine();

                    Merchandise merch1 = new Merchandise();
                    merch1.Type = merchandise;
                    merch1.Name = order;
                    merch1.Price = 25.00;

                    Console.WriteLine(merch1.ToString());
                }
                else if (merchandise.ToUpper() == "WATER BOTTLES")
                {
                    Console.WriteLine($"What is the name of the {merchandise} drink");
                    string order = Console.ReadLine();

                    Merchandise merch1 = new Merchandise();
                    merch1.Type = merchandise;
                    merch1.Name = order;
                    merch1.Price = 15.75;

                    Console.WriteLine(merch1.ToString());
                }
                else if (merchandise.ToUpper() == "OTHER")
                {
                    Console.WriteLine($"What is the name of the {merchandise} drink");
                    string order = Console.ReadLine();

                    Merchandise merch1 = new Merchandise();
                    merch1.Type = merchandise;
                    merch1.Name = order;
                    merch1.Price = 1.25;

                    Console.WriteLine(merch1.ToString());
                }
                else
                {
                    Console.WriteLine("Sorry item not in our menu!!");
                }
            }
                else
                {
                    Console.WriteLine("Sorry Wrong input");
                }

            }


        }
    }
 

