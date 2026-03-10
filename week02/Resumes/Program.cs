using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2023;


        
        Job job2 = new Job();
        job2._jobTitle = "Software Intern";
        job2._companyName = "Monyetech limited";
        job2._startYear = 2023;
        job2._endYear = 2025;

        job1.Display();
        job2.Display();
    }
}