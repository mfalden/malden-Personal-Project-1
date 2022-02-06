using System;
using System.Collections.Generic;
using System.IO; 
using System.Linq;

namespace malden_Personal_Project_1
{
    
    public class HighScoreTracker
    {   

        public static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return;
            }
        }
        public static void TestAll()
        {
            bool testAddScore = TestAddScore.RunTest();
            Console.WriteLine($"Test AddScore(string userName, string userScore, int insertAt, List<int> scoreList): {testAddScore}");

            bool testLoadScoresFile = TestLoadScoresFile.RunTest();
            Console.WriteLine($"Test LoadScoresFile(string scoresFile): {testLoadScoresFile}");

            bool testScoreCompare = TestScoreCompare.RunTest();
            Console.WriteLine($"Test ScoreCompare(List<int> scoresOnly, string userScore): {testScoreCompare}");
            
            // because "scoresonly" in test depends on the output of ScoreSplit, test will be unable to run and will throw exceptions.
            // bool testScoreSplit = TestScoreSplit.RunTest();
            // Console.WriteLine($"Test ScoreSplit(List<string> scoreList): {testScoreSplit}");

            bool testUserScore = TestUserScore.RunTest();
            Console.WriteLine($"Test UserScore(): {testUserScore}");
        }
        /// <summary>
        /// Loads the "scoresfile.txt" file and stores it in list "ScoreList". 
        /// </summary>
        /// <param name="scoresFile">a .txt file storing all scores.</param>
        /// <returns>Returns "ScoreList".</returns>
        public static List<string> LoadScoresFile(string scoresFile)
        {
                // 1. Create list scoreList
                // 2. scorelist = file.ReadLines(scoresfile.txt);
                // 3. return list scorelist
                List<string> scoreList;
                List<string> errorList = new List<string>();
                errorList.Add("This file does not exist!");
                if(File.Exists(scoresFile) == false)
                {
                    // Feedback(jcollard 2022-02-05): I would recommend either
                    // throwing an exception or returning null:
                    //
                    // throw new Exception($"The file {scoresFile} does not exist.");
                    return errorList;
                }
                scoreList = File.ReadAllLines(scoresFile).ToList();
                return scoreList;
        }

        /// <summary>
        /// Loads the list "ScoreList" and takes the score values only.
        /// </summary>
        /// <param name="scoreList">A list of all usernames and their scores</param>
        /// <returns>Returns int list "ScoresOnly".</returns>
        public static List<int> ScoreSplit(List<string> scoreList)
        {
                // 1. Split the scoreList along all spaces (" ")
                // 2. create new list<int> = scoresOnly
                // 3. add element 2 using int.Parse(scoresOnly[1]);
                // 4. return list<int> scoresOnly;
            return null;
        }

        /// <summary>
        /// prompts the user's name and score values and stores them in two strings, "userScore" and "userName".
        /// </summary>
        /// <returns>The function returns userScore and userName.</returns>
        public static (int, string) UserScore()
        {
            // 1. create string userName
                // 2. create int userScore
                // 3. display "please type in your name"
                // 4. collect user input
                // 5. trim user input
                // 6. add to string userName
                // 7. start of loop: display "please type in your score"
                // 8. collect user input
                // 9. trim user input
                // 10. if the score includes letters, display "invalid score" and restart the loop. If the score is only numbers, add the user input to integer userScore
                // 11. Return int userScore, string userName
            string score;
            bool isValidScore;

            Console.Write("Please type in your name: "); 
            string userName = Console.ReadLine().Replace(" ", ""); 

            do
            {
                Console.Write("Enter your score: "); 
                score = Console.ReadLine().Replace(" ", "");
                isValidScore = true; 
                foreach (char c in score)
                {
                    if (char.IsDigit(c) == false)
                    {
                        Console.WriteLine("Please type in a valid score.");
                        isValidScore = false; 
                        break;
                    } 
                }
            } while (isValidScore == false); 
            
            
            return (int.Parse(score), userName);
        }
        
        /// <summary>
        /// Takes the string "userscore" and compares it to the values in scoresOnly, stopping only when the userScore is greater than the value in an index of scoresOnly.
        /// </summary>
        /// <param name="scoresOnly">A list containing the scores of past players</param>
        /// <param name="userScore">The user's score</param>
        /// <returns>returns the index number of the row where userScore was greater than scoresOnly in an integer "insertAt".</returns>
        public static int ScoreCompare(List<int> scoresOnly, int userScore)
        {
                // 1. load list<int> scoresOnly and int userScore
                // 2. create new int inserAt and set to 0
                // 3. start of loop: for each line in scoresOnly--
                // 4. if the user score is less than scoresOnly, increase int insertAt by one and restart the loop
                // 5.0 if the user score is equal to scoresOnly, return int insertAt
                // 5. if the user score is greater than scores only, return int insertAt
            
            return -1;
        }

        /// <summary>
        /// Takes the "userName" and "userScore" strings, combines them into a string entry and inserts them into the list "scorelist" at the index specified by int "insertAt". It then displays all scores.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userScore"></param>
        /// <param name="insertAt"></param>
        /// <param name="scoreList"></param>
        public static void AddScore(string userName, string userScore, int insertAt, List<string> scoreList)
        {
            // string entry;
                // 1. Load in the userName, userScore, insertAt, and scoreList variables. 
                // 2. Create String "entry" $"{userName} {userScore}"
                // 3. Insert "entry" at index "insertAt" 
                // 4. Using WriteLine, Display list scoreList
                // 5. Using File.WriteLines, override all entries in scoresFile.txt to be entries from list scoreList
        }
    }
}
