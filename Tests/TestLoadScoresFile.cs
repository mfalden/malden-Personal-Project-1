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
            Console.WriteLine("ScoreList should be:\n500\n1000\n1500");
            Console.WriteLine($"ScoreList:{scoreList}");
            Console.WriteLine("Does this look right to you?");
            return false;
        }
    }
}