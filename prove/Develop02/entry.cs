using System;
using System.Runtime.CompilerServices;
public class Entry {
        public string input;
    
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
            combinedResult += "%#$";
            return combinedResult;
        }
        
    }