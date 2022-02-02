using System;
using System.Collections.Generic;
using System.IO; 
using System.Linq; // Feedback(jcollard: 2022-02-01): This allows us to convert a file to a list of strings

namespace malden_Personal_Project_1
{
    
    public class HighScoreTracker
    {   

        public static void Main(string[] args)
        {
            // Feedback(jcollard 2022-01-28): You're off to a great start! I've
            // added a few compilation fixes as well as a handful of TODOs.
            // In class today, complete the TODOs then move on to Part 2.2.
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return;
            }
        }
        public static void TestAll()
        {
            // Feedback(jcollard 2022-02-02): Great job on this section.
            // This section looks like it will report properly.
            bool testAddScore = TestAddScore.RunTest();
            Console.WriteLine($"Test AddScore(string userName, string userScore, int insertAt, List<int> scoreList): {testAddScore}");

            bool testLoadScoresFile = TestLoadScoresFile.RunTest();
            Console.WriteLine($"Test LoadScoresFile(string scoresFile): {testLoadScoresFile}");

            bool testScoreCompare = TestScoreCompare.RunTest();
            Console.WriteLine($"Test ScoreCompare(List<int> scoresOnly, string userScore): {testScoreCompare}");
            
            bool testScoreSplit = TestScoreSplit.RunTest();
            Console.WriteLine($"Test ScoreSplit(List<string> scoreList): {testScoreSplit}");

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

                // Feedback(jcollard 2022-02-01): I modified your code to show you
                // how to load the file into a list.
                scoreList = File.ReadAllLines("scoresFile.txt").ToList();
                foreach (string line in scoreList)
                {
                    scoreList.Add(line);
                }             
                return scoreList;
        }

        /// <summary>
        /// Loads the list "ScoreList" and takes the score values only.
        /// </summary>
        /// <param name="scoreList">A list of all usernames and their scores</param>
        /// <returns>Returns int list "ScoresOnly".</returns>
        static List<int> ScoreSplit(List<string> scoreList)
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
            // THIS IS NOT WORKING LOL but the test is :)
            string userName;
            string score;
            int userScore;
            Console.WriteLine("Please type in your name.");
            userName = Console.ReadLine();
            userName = userName.Replace(" ", "");
            Console.WriteLine("Please type in your score.");
        scoreLoop:
        // I think my error is somewhere in here. Somehow converting "900" to "153". UserName IS working correctly.
            score = Console.ReadLine();
            score = score.Replace(" ", "");
            userScore = 0;
            foreach (char c in score)
            {
            if (char.IsDigit(c) == false) 
            {
                Console.WriteLine("Please type in a valid score.");
                // TODO(jcollard 2022-02-02): goto is considered one of the
                // worst programming practices because it can result in code
                // incredibly hard to understand. You should replace this with a
                // while loop instead.
                goto scoreLoop;
            }
            else 
            {
                userScore += c; 
            }
            }
            return (userScore, userName);
        }

        // Feedback(jcollard 2022-02-02): Here is an example of how you might
        // rewrite your code to be a little more manageable. Note: This is
        // incomplete but shows a high level idea.
        public static (int, string) FeedbackUserScore()
        {
            string userName = null;
            string score = "somescore";
            int userScore = -1;

            while (true)
            {
                string userInput = Console.ReadLine();
                if (ValidateScoreInput(userInput))
                {
                    return (userScore, userName);        
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }

        // Feedback(jcollard 2022-02-02): This is a simple method which checks
        // if the input contains only digits. If it does, returns true. Otherwise, returns false.
        public static bool ValidateScoreInput(string toCheck)
        {
            foreach (char c in toCheck)
            {
                if (char.IsDigit(c) == false)
                {
                    return false;
                }
            }
            return true;
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
            string entry;
                // 1. Load in the userName, userScore, insertAt, and scoreList variables. 
                // 2. Create String "entry" $"{userName} {userScore}"
                // 3. Insert "entry" at index "insertAt" 
                // 4. Using WriteLine, Display list scoreList
                // 5. Using File.WriteLines, override all entries in scoresFile.txt to be entries in list scoreList
        }
    }
}
