using System;

namespace _P__String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = ("Programming today is a race software engineers striving engineers striving to build bigger and better idiot proof programs, and the univers trying to build bigger and better idiots. So far, the universe is winning.");
            
            string[] words = new string[_wordCount];
            string[] splitSentence = new string[_wordCount];
            for (int j= 0; j < words.Length; j++)

            {
                Console.WriteLine("What word are you trying to find and replace in the statement above?");
                String find = Console.ReadLine();
                string[] splitSentence = message.Split(' ', '.', ',');
                
                Console.WriteLine("With what word would you like to replace it with?");
                String Console.ReadLine();

                if (splitSentence[j] == words[i])
                   splitSentence[j] == words[i].Replace(words[i], "*");

            }   


        }
    }
}

     