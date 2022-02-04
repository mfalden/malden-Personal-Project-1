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

                // Feedback(jcollard 2022-02-04): You're doing a lot of extra
                // work in this method. There is no need to loop through the
                // list and copy it to a new list. It could be rewritten as:
                //
                // List<string> scoreList;
                // scoreList = File.ReadAllLines(scoresFile).ToList();
                // return scoreList;
                //
                // Or even just:
                // return File.ReadAllLines(scoresFile).ToList();

                List<string> rawscoreList;
                rawscoreList = new List<string>();
                List<string> scoreList;
                scoreList = new List<string>();
                // Feedback(jcollard 2022-02-01): I modified your code to show you
                // how to load the file into a list.
                // in use: instead of "scoresfile" insert the scoresfile.txt. OR add in a load-in from the terminal.
                rawscoreList = File.ReadAllLines(scoresFile).ToList();
                foreach (string line in rawscoreList)
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

            // Feedback(jcollard 2022-02-04): Great work getting this to work!
            // I've added another version below called SimplifiedUserScore()
            // which I believe is slightly easier to read. It uses a 
            // `do ... while` loop which allows us to eliminate some of the
            // redundant code. Additionally, it removes the "makeloopwork"
            // variable as well as a redundant "else { continue; }"
            // I hope you find it helpful!
            string userName;
            string score;
            int userScore = 0;
            Console.WriteLine("Please type in your name.");
            userName = Console.ReadLine();
            userName = userName.Replace(" ", "");
            Console.WriteLine("Please type in your score.");
            bool makeloopwork = true;
            bool isValidScore = true;
            while (makeloopwork)
            {   isValidScore = true;
                score = Console.ReadLine();
                score = score.Replace(" ", "");
                foreach (char c in score)
                {
                    if (char.IsDigit(c) == false) 
                    {
                        Console.WriteLine("Please type in a valid score.");
                        isValidScore = false;
                        break;
                    }
                    else 
                    {
                        continue;
                    }
                }
                if (isValidScore)
                {
                userScore = int.Parse(score);
                makeloopwork = false;
                }
                else 
                {
                    continue;
                }
            }
            return (userScore, userName);
        }

        // Feedback(jcollard 2022-02-04): Here is a version of UserScore which I
        // believe is slightly more concise. Study it, compare it to your
        // solution and let me know if you have any questions.
        public static (int, string) SimplifiedUserScore()
        {
            string score;
            bool isValidScore;

            Console.Write("Please type in your name: "); // I use "Write" rather than "WriteLine" which will make the users input appear after the colon
            string userName = Console.ReadLine().Replace(" ", ""); // We can "chain" these method calls together. 

            do
            {
                Console.Write("Enter your score: "); // We now ask this inside of the loop so we only need it once
                score = Console.ReadLine().Replace(" ", "");
                isValidScore = true; // Assume the score is valid until we find it is not valid
                foreach (char c in score)
                {
                    if (char.IsDigit(c) == false)
                    {
                        Console.WriteLine("Please type in a valid score.");
                        isValidScore = false; // It wasn't valid so we set isValidScore to false and exit this loop
                        break;
                    } // I removed the else { continue; } because it is implied that we will continue
                }
            } while (isValidScore == false); // If the score is not valid, loop.
            
            // Once we have a valid score, parse it and return it with the userName
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
