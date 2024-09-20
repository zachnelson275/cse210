using System;

Console.Write("What is your grade? ");
string valueInText = Console.ReadLine();
int grade = int.Parse(valueInText);
string letterGrade;

if (grade >= 90)
{
    letterGrade = "A";
}

else if (grade >= 80)
{
    letterGrade = "B";
}
else if (grade >= 70)
{
    letterGrade = "C";
}

else if (grade >= 60)
{
    letterGrade = "D";
}

else
{
    letterGrade = "F";
}


Console.WriteLine($"Your final letter grade: {letterGrade}");
if (letterGrade == "C" || letterGrade == "B" || letterGrade == "A")
{
    Console.WriteLine("You passed! Congratulations");
}

else{
    Console.WriteLine("Sorry, you're just a little dumb for this course. Better luck next time");
}