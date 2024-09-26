using System;
using System.Globalization;

static void DisplayWelcome()
{
    Console.WriteLine("Welcome to the Program!");
}

static string PromptUserName()
{
    Console.WriteLine("Please enter your name:  ");
    string name = Console.ReadLine();
    return name;
}

static int PromptUserNumber()
{
    Console.WriteLine("Please enter your favorite number:  ");
    string entry = Console.ReadLine();
    int number = int.Parse(entry);
    return number;
}

static int SquareNumber(int number)
{
    int square_number = number * number;
    return square_number;
}

static void DisplayResult(string name, int number)
{
    Console.WriteLine($"{name}, the square of your number is {number}");
}

static void Main()
{
    DisplayWelcome();
    string name = PromptUserName();
    int num = PromptUserNumber();
    int sq_num = SquareNumber(num);
    DisplayResult(name, sq_num);
}

Main();