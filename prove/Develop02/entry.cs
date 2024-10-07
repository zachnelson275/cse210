using System;
using System.Runtime.CompilerServices;
public class Entry {
        public string input;
        public string[] promptList = ["Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I could do over one thing today, what would it be?", "What is one thing I learned today?", "Who did I serve today?"];
        public DateTime CurrentDate { get; set; }


        public static string getInput()
        {
            string input = Console.ReadLine();
            return input;
        }
        public static string randomizePrompt(string[] promptList)
        {
            Random random = new Random();
            int randomIndex = random.Next(promptList.Length);
            return promptList[randomIndex];
        }
        public Entry()
        {
            CurrentDate = DateTime.Now;
        }
        public static string combineString(string prompt, DateTime date, string input)
        {
            string combinedResult = "";
            combinedResult += "Date: " + date + " - Prompt: " + prompt;
            combinedResult += input;
            return combinedResult;
        }
        
    }