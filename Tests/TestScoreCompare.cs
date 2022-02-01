using System;
using System.Collections.Generic;
using System.IO; 

namespace malden_Personal_Project_1
{
    class TestScoreCompare
    {
        public static bool RunTest()
        {
            
            int userScore = 900;
            List<int> scoresOnly; // finish after LoadScoresFile is tested.
            HighScoreTracker.ScoreCompare(scoresOnly, userScore);
            int insertAt = HighScoreTracker.ScoreCompare(scoresOnly, userScore);
            if (insertAt != 1)
            {
                Console.WriteLine("Int inserAt should be 1, but that is not the case.");
                Console.WriteLine($"Int insertAt: {insertAt}");
                return false;
            }
            else 
            {
                return true;
            } 
        }
    }
}