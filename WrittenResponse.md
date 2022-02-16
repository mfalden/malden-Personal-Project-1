# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

This program can be used by a game developer seeking a high score tracker for their game.

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

The video shows how the program accepts a user's name and score, sorts them into a high score .txt file based on score, and then displays said .txt file.

### 3a iii.

Describes the input and output of the program demonstrated in the video.

The inputs to the program are a name and a score, and the output is an updated .txt file.

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
// TODO: Copy The line of code here for which you are adding data to a list
List<string> scoreList;
            if (File.Exists(scoresFile) == false)
            {
                throw new Exception($"The file {scoresFile} does not exist.");
            }
            scoreList = File.ReadAllLines(scoresFile).ToList();
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
List<int> scoresOnly = new List<int>();
            foreach (string line in scoreList)
            {
                if (!line.Equals(""))
                {
                    scoresOnly.Add(int.Parse(line.Split(' ')[1]));
                }
            }
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable "scoreList".

### 3b iv.

Describes what the data contained in the list represents in your program

"scoreList" represents the usernames and scores stored in a .txt file "scoresFile" in list format.

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

Without a list, I would have to create an arbitrary amount of variables to store user's high scores, limiting the amount of high scores my program could handle. 

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public static List<int> ScoreSplit(List<string> scoreList)
        {

            if (scoreList == null)
            {
                throw new Exception("String scoreList is null!");
            }
            List<int> scoresOnly = new List<int>();
            foreach (string line in scoreList)
            {
                if (!line.Equals(""))
                {
                    scoresOnly.Add(int.Parse(line.Split(' ')[1]));
                }
            }
            return scoresOnly;
        }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
List<int> scoresOnly = ScoreSplit(scoreList);
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

ScoreSplit takes scoreList, which stores usernames and scores, and returns only its scores in scoresOnly. This is needed to sort a user's score into the overall list.

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

**TODO: In English, explain step by step what your procedure does. Be sure to use the word `Selection` and `Iteration` to explain what it does.**
1. Create a new integer list scoresOnly.
2. Iterate through each line of scoreList
3. Select non-empty lines and split the line on a space
4. Add the second element to scoresOnly 
5. Finally, it returns scoresOnly. 

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

```csharp
scoreSplit(null);
```

Second call:

```csharp
scoreSplit(scoreList);
```

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call: 
 
Testing if inputting null, which represents the lack of a list, triggers the program exception and closes the program.

Condition(s) tested by the second call:

Testing if inputting an actual list does not trigger the program exception, runs the code, and returns the second element of that list: its scores. 

### 3d iii.

Result of the first call:

"String scoreList is null!"

Result of the second call:

if scoreList is:
User1 500
User2 1000
User3 1500

then output is:
500
1000
1500

