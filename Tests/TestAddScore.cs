using System;
using System.Collections.Generic;
using System.IO; 

namespace malden_Personal_Project_1
{
    class TestAddScore
    {
        public static bool RunTest()
        {   
            // Load variables
            string userName = "TestName";
            string userScore = "900";
            int insertAt = 1; 
            List<string> scoreList = HighScoreTracker.LoadScoresFile("fake_scores.txt");

            if (scoreList.Count != 4)
            {
                Console.Error.WriteLine("The file should have 4 lines but that was not the case.");
                return false;
            }

            if(scoreList[1] != "TestName 900")
            {
                Console.Error.WriteLine("The first file should have been \"TestName 900\"");
                return false;
            }
            return false;
        }
    }
}