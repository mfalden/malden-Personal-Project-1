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
            string userScore = "900";
            int insertAt = 1; 
            List<int> indexTest = new List<int>();
            indexTest.Add(0);
            indexTest.Add(1);
            indexTest.Add(2);
            indexTest.Add(3);
            List<string> scoreList;
            scoreList = new List<string>(); // Feedback(jcollard 2022-02-04): You can delete this line of code. This is because you reassign scoreList on the next line
            scoreList = HighScoreTracker.LoadScoresFile("Tests/fake_scores.txt");
            HighScoreTracker.AddScore(userName, userScore, insertAt, scoreList);
            List<string> scoresCheck = new List<string>();// Feedback(jcollard 2022-02-04): You can delete the "new List<string>()" part of this line. This is because you reassign scoresCheck on the next line
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
            
            { // Feedback(jcollard 2022-02-04): This set of curly brackets is not necessary.
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
}