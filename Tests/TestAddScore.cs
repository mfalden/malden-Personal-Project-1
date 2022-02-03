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
            File.Copy("Tests/fake_scores_clean.txt", "Tests/fake_scores.txt", true);
            string userName = "TestName";
            string userScore = "900";
            int insertAt = 1; 
            List<string> scoreList;
            scoreList = new List<string>();
            scoreList = HighScoreTracker.LoadScoresFile("Tests/fake_scores.txt");
            HighScoreTracker.AddScore(userName, userScore, insertAt, scoreList);

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

            else
            {
            return true;
            }

        }
    }
}