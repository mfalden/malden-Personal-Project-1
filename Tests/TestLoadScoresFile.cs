using System;
using System.Collections.Generic;
using System.IO; 

namespace malden_Personal_Project_1
{
    class TestLoadScoresFile
    {
        public static bool RunTest()
        {   
            // TODO(jcollard 2022-02-04): What should happen if you call this method with a file that does not exist? e.g. LoadScoresFile("NotAFile.txt")
            List<string> scoreList;
            HighScoreTracker.LoadScoresFile("scoresFile.txt");
            scoreList = HighScoreTracker.LoadScoresFile("scoresFile.txt");
            Console.WriteLine("ScoreList should be:\nUser1 500\nUser2 1000\nUser3 1500");
            Console.WriteLine("ScoreList:");
            foreach (string line in scoreList)
            {
                Console.WriteLine($"{line}");
            }
            List<string> fail = HighScoreTracker.LoadScoresFile("notAFile.txt");
            foreach (string line in fail)
            {
                Console.WriteLine($"Testing instance of a file that does not exist:\nExpected: 'This file does not exist!'\nReturned: '{line}'");
            }
            Console.WriteLine("Does this look right to you?");
            return false;
        }
    }
}