using System;

namespace _P__Simple_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            Console.WriteLine("Enter the name of an animal");
            answer = Console.ReadLine().ToLower();
            
            if (answer == "dog")
            {
                Console.WriteLine("Woaf");
                Console.WriteLine(animals[0].getSound());

            }
            else if (answer == "monkey")
            {
                Console.WriteLine(" ");
            }
            else if (answer == "goat")
            {
               Console.WriteLine(" ");
            }
            else
            {
               Console.WriteLine(" ");
            }
        }
    }
   static public string Speak(string sound)
    {
        string[] sounds = new string[4];
        sounds[0] = new string("dog", "DogSound");
        sounds[1] = new string("monkey", "MonkeySound");
        sounds[2] = new string("goat", "GoatSound");
        sounds[3] = new string("animal", animalSound);

    }

   }

