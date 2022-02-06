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
            // TODO(jcollard 2022-02-05): The following line *should* cause an exception to be thrown. This will cause
            // your program to crash unless it is wrapped in a try / catch block.
            // vv is the following correct? 
            Console.WriteLine($"Testing instance of a file that does not exist");
            try 
            {
                HighScoreTracker.LoadScoresFile("notAFile.txt");
                return false;
            }
            catch
            {
                
            }
            
            // It could be useful to add in a user input here:
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