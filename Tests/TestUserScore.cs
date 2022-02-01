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
        HighScoreTracker.UserScore();
        (int, string) result = HighScoreTracker.UserScore();
        Console.WriteLine("String userName should be 'TestName', and Int userScore should be '900'.");
        Console.WriteLine($"UserScore --> {result} <-- UserName");
        Console.WriteLine("Does the method appear to be working?");
        //string userName = "";
        //     int userScore = 0;
        //     // no variables loaded
        //     HighScoreTracker.UserScore();
        //     Console.WriteLine("Type 'TestName  '");
        //     Console.WriteLine("Type '900'");
        //     if (userName != "TestName")
        //     {
        //         Console.WriteLine("String userName should be 'TestName' but it is not.");
        //         return false;
        //     }
            // if (userScore != 900)
            // {
            //     Console.WriteLine("Int userScore should be '900' but it is not.");
            //     return false;
        //     }
        //     else 
        //     {
        //         return false;
        //     }
        return false;
        }
    }
}