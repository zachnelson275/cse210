using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       job1._jobTitle = "Software Engineer";
       job1._company = "Northrup Grummon";
       job1._startYear = 2012;
       job1._endYear = 2015;

       Job job2 = new Job();
       job2._jobTitle = "General Manager";
       job2._company = "Wendy's";
       job2._startYear = 2005;
       job2._endYear = 2011;

       Resume resume1 = new Resume();
       resume1._name = "Zach Nelson";
       resume1._jobs = [job1, job2];
       
       resume1.Display();
    }
}