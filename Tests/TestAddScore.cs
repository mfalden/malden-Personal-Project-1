using System;
using System.Collections.Generic;
using System.IO; 

namespace malden_Personal_Project_1
{
    class TestAddScore
    {
        public static bool RunTest()
        {   
            File.Copy("Tests/fake_scores_clean.txt", "Tests/fake_scores.txt", true);
            string userName = "TestName";
            int userScore = 900;
            int insertAt = 1; 
            List<int> indexTest = new List<int>();
            indexTest.Add(0);
            indexTest.Add(1);
            indexTest.Add(2);
            indexTest.Add(3);
            List<string> scoreList;
            scoreList = HighScoreTracker.LoadScoresFile("Tests/fake_scores.txt");
            HighScoreTracker.AddScore(userName, userScore, insertAt, scoreList, "Tests/fake_scores.txt");
            List<string> scoresCheck;
            scoresCheck = HighScoreTracker.LoadScoresFile("Tests/fake_scores.txt");
            if (scoreList.Count != 4)
            {
                Console.Error.WriteLine("The scoreList list should have 4 lines but that was not the case.");
                return false;
            }
            if(scoreList[1] != "TestName 900")
            {
                Console.Error.WriteLine("The second entry should have been \"TestName 900\"");
                return false;
            }
            foreach (int index in indexTest)
            {
                if (scoreList[index] != scoresCheck[index])
                {
                    Console.Error.WriteLine("The list scoreList did not copy over to the .txt file.");
                    return false;
                }
            }
            return true;

        }
    }
}