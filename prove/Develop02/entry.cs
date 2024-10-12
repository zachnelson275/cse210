using System;
using System.Runtime.CompilerServices;
public class Entry {
        public string input;
    
        public DateTime CurrentDate = DateTime.Now;


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
        
        public static string combineString(string prompt, DateTime date, string input)
        {
            string combinedResult = "";
            combinedResult += "Date: " + date + " - Prompt: " + prompt + "\n";
            combinedResult += input;
            return combinedResult;
        }
        
    }