using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Fraction fraction = new();
        Fraction fraction1 = new(5);
        Fraction fraction2 = new(6, 7);

        Console.WriteLine($"{fraction.GetDecimalValue()} {fraction1.GetDecimalValue()} {fraction2.GetDecimalValue()}");

    }
}