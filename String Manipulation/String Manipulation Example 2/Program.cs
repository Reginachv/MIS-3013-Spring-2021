using System;

namespace String_Manipulation_Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = ("tAylOr SwIFt, tHe WeEknD, TRaVis sCoTt, aRiANa gRAndE, bIlLiE eiLiSH");

            string msg2 = "tAylor SwIFt";
            int indexOfSpace = msg2.IndexOf(' ');
            /* msg2 = msg2.ToUpper()[0] + msg2.ToLower().Substring(1, 6)
                    + msg2.ToUpper()[indexOfSpace + 1] + msg2.ToLower().Substring(indexOfSpace + 2);
            
            Console.WriteLine(msg2); */
            return; 

            //string msg2 = message.ToLower();
            //string msg3 = msg2.Substring(1);
            string newMessage = message.ToUpper()[0] + message.ToLower().Substring(1);
            Console.WriteLine(newMessage);

            string[] artists = message.Split(',');

            for (int i = 0; i < artists.Length; i++)
            {
                string artist = artists[i].Trim();

                string[] names = artist.Split(' ');
                string firstName = names[0];
                string lastName = names[1];

                string NewArtist = firstName.ToUpper()[0] + firstName.ToLower().Substring(1) + " " +
                                   lastName.ToUpper()[0] + lastName.ToLower().Substring(1);

                Console.WriteLine(NewArtist);
            }
    }
}
