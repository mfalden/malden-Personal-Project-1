using System;
using System.Collections.Generic;
using System.IO; 

namespace malden_Personal_Project_1
{
    class TestLoadScoresFile
    {
        public static bool RunTest()
        {   
            List<string> scoreList;
            HighScoreTracker.LoadScoresFile("scoresFile.txt");
            scoreList = HighScoreTracker.LoadScoresFile("scoresFile.txt");
            Console.WriteLine("ScoreList should be:\nUser1 500\nUser2 1000\nUser3 1500");
            Console.WriteLine("ScoreList:");
            foreach (string line in scoreList)
            {
                Console.WriteLine($"{line}");
            }
            Console.WriteLine("Does this look right to you?");
            return false;
        }
    }
}