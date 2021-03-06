using System;

namespace _P__String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Programming today is a race software engineers striving engineers striving to build bigger and better idiot proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(message);

            Console.WriteLine("\nWhat word are you trying replace in the statement above?");
            string find = Console.ReadLine();

            if (message.Contains(find) == true)
            {
               // Console.WriteLine("\n'{0}' is in the string '{1}': {2}", find, message);

                Console.WriteLine("\n What word would you like to display instead?");
                string replace = Console.ReadLine();

                string[] words = message.Split(' ', '.', ',');
                string output = message;
                for (int i = 0; i < words.Length; i++)
                {
                    output = output.Replace(find, replace);
                }

                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Sorry, I could not find your word " + find);
               
               // string[] words = find.Split(' ');
                char[] tempArray = find.ToCharArray();
                Array.Reverse(tempArray);
                string reversedFind = new String(tempArray);

                //Console.WriteLine("Find is: " + find);
                Console.WriteLine("Your word reversed is: " + reversedFind);
            }   
        
            }
        }
    }



     