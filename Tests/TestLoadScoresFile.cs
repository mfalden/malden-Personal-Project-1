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
            Console.WriteLine("ScoreList should be:\nUser1 500\nTestName 900\nUser2 1000\nUser3 1500");
            Console.WriteLine("ScoreList:");
            foreach (string line in scoreList)
            {
                Console.WriteLine($"{line}");
            }
            Console.WriteLine("Does this look right to you?");
            Console.WriteLine($"Testing instance of a file that does not exist");
            try 
            {
                HighScoreTracker.LoadScoresFile("notAFile.txt");
                return false;
            }
            catch
            {
                
            }
            
            Console.Write("Does this look correct? Type 'y' to pass.");
            string input = Console.ReadLine();
            if (input != "y")
            {
                return false;
            }

            return true;
        }
    }
}