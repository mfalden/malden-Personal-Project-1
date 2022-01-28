using System;
using System.Collections.Generic;
using System.IO; 

namespace malden_Personal_Project_1
{
    
    class HighScoreTracker
    {   

        static void Main(string[] args)
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
        static List<string> LoadScoresFile(string scoresFile)
        {
                // 1. Create list scoreList
                // 2. scorelist = file.ReadLines(scoresfile.txt);
                // 3. return list scorelist

                List<string> scoreList;
                scoreList = new List<string>();
                foreach (string line in File.ReadLines("scoresFile.txt"))
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
            string userName;
            string score;
            int userScore;
            Console.WriteLine("Please type in your name.");
            userName = Console.ReadLine();
            userName.Trim();
            Console.WriteLine("Please type in your score.");
        scoreLoop:
            score = Console.ReadLine();
            userScore = 0;
            foreach (char c in score)
            {
            if (char.IsDigit(c) == false) 
            {
                Console.WriteLine("Please type in a valid score.");
                goto scoreLoop;
            }
            else 
            {
                userScore += c; 
            }
            }
            return (userScore, userName);
        }
        /// <summary>
        /// Takes the string "userscore" and compares it to the values in scoresOnly, stopping only when the userScore is greater than the value in an index of scoresOnly.
        /// </summary>
        /// <param name="scoresOnly">A list containing the scores of past players</param>
        /// <param name="userScore">The user's score</param>
        /// <returns>returns the index number of the row where userScore was greater than scoresOnly in an integer "insertAt".</returns>
        public static int ScoreCompare(List<int> scoresOnly, string userScore)
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
        static void AddScore(string userName, string userScore, int insertAt, List<int> scoreList)//TODO(jcollard 2022-01-28): Add `public` to the beginning of this line
        {
                // 1. Load in the userName, userScore, insertAt, and scoreList variables. 
                // 2. Create String "entry" $"{userName} {userScore}"
                // 3. Insert "entry" at index "insertAt" 
                // 4. Using WriteLine, Display list scoreList
                // 5. Using File.WriteLines, override all entries in scoresFile.txt to be entries in list scoreList
        }
    }
}
