using System;
using System.Collections.Generic;
using System.IO; 
using System.Linq;

namespace malden_Personal_Project_1
{
    class TestScoreSplit
    {
        public static bool RunTest()
        {
            // running into same issue: LoadScoresFile needed for these tests (for transferring scoresFile to scoreList)
            List<string> rawscoreList; 
            rawscoreList = File.ReadAllLines("Tests/fake_scores.txt").ToList();
            List<string> scoreList; 
            scoreList = new List<string>();
                foreach (string line in rawscoreList)
                {
                    scoreList.Add(line);
                }
            HighScoreTracker.ScoreSplit(scoreList);
            List<int> scoresOnly;
            scoresOnly = new List<int>();
            scoresOnly = HighScoreTracker.ScoreSplit(scoreList);
            Console.WriteLine("scoresOnly should be:\n500\n1000\n1500");
            Console.WriteLine("ScoresOnly:");
            foreach (int score in scoresOnly)
            {
                Console.WriteLine($"\n{score}");
            }
            Console.WriteLine("Does this look right to you?");
            return false;
        }
    }
}