using System;
using System.Runtime.CompilerServices;

List<int> numbers = new List<int>();
int entry = -1;
string intoInt;
int average;
int sum = 0;
int length = 0;

Console.WriteLine("Enter numbers for your list, enter 0 when finished");

while (entry != 0)
{
    Console.Write("Enter a number:  ");
    intoInt = Console.ReadLine();
    entry = int.Parse(intoInt);
    numbers.Add(entry);
}

foreach (int number in numbers)
{
    sum += number;
}

length = numbers.Count - 1;
average = sum / length;

Console.WriteLine();
Console.WriteLine($"The sum is:     {sum}");
Console.WriteLine($"The average is: {average}");