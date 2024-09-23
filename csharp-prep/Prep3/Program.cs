using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int number = rnd.Next(1, 101);
        string response;
        int guess = -1;
        while (guess != number)
        {
            Console.WriteLine("What's your guess?  ");
            response = Console.ReadLine();
            guess = int.Parse(response);

            if (guess < number) 
            {
                Console.WriteLine("Too low :(");
            }
            else if (guess > number)
            {
                Console.WriteLine("Too high :(");
            }
            else if (guess == number)
            {
                Console.WriteLine("You got it!");
            }
        }
    }
}