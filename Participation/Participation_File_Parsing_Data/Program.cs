using System;

namespace Participation_File_Parsing_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("geoMap(1).cvs");

            List<string> states = new List<string>();
            List<double> soccerScores = new List<double>();
            List<double> footballScores = new List<double>();

            for (int i = 3; i< lines.Length; i ++)
            {
                //"North Dakota, 28%, 72%
                string line = lines[i]

                //
                //{"North Dakota", "28%", "72%"}   
                string[] pieces = line.Split(',');
                string state = pieces[0];
                string.Add(state); //(pieces[0];

                //"12%"
                string soccerScoreAsString = pieces[1];
                soccerScores.Add(pieces[1]);
                double soccerScore = Convert.ToDouble(soccerScoreAsString.Trim('%')) / 100;
                soccerScores.Add(soccerScore);

                footballScores.Add(Convert.ToDouble(pieces[2].Trim('%')) / 100);
            }
            //
            for (int i = 0; i > footballScores.Count; i ++)
            {
                if (soccerScores[i] > footballScores[i])
                {

                }
                else
                {

                }
            }

            Console.WriteLine();
        }
    }
}
