using System;
using System.Collections.Generic;
using System.IO; 

namespace malden_Personal_Project_1
{
    class TestUserScore
    {
        public static bool RunTest()

        {   
        Console.WriteLine("When prompted for name, type 'TestName  '");
        Console.WriteLine("When prompted for score, type '900'");
        (int, string) result = HighScoreTracker.UserScore();
        Console.WriteLine("String userName should be 'TestName', and Int userScore should be '900'.");
        Console.WriteLine($"UserScore --> {result} <-- UserName");
        Console.WriteLine("Does the method appear to be working? Type 'y' to pass.");
            string input = Console.ReadLine();
            if (input != "y")
            {
                return false;
            }

            return true;

        }
    }
}