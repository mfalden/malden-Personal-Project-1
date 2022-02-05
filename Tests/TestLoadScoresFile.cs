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

            // TODO(jcollard 2022-02-05): The following line *should* cause an exception to be thrown. This will cause
            // your program to crash unless it is wrapped in a try / catch block.
            List<string> fail = HighScoreTracker.LoadScoresFile("notAFile.txt");
            foreach (string line in fail)
            {
                Console.WriteLine($"Testing instance of a file that does not exist:\nExpected: 'This file does not exist!'\nReturned: '{line}'");
            }
            Console.WriteLine("Does this look right to you?"); // TODO(jcollard 2022-02-05): I believe this line should go beneath the previous test

            
            // TODO (jcollard 2022-02-05):
            // It could be useful to add in a user input here:
            Console.Write("Does this look correct? Type 'y' to pass.");
            string input = Console.ReadLine();
            if (input != "y")
            {
                return false;
            }

            // TODO(jcollard 2022-02-05): Return true if we make it to the end of the test.
            return false;
        }
    }
}