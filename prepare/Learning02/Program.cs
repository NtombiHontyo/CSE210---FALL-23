using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2024;
        job1._endYear = 2028;


        Job job2 = new Job();
        job2._company = "Amazon";
        job2._jobTitle = "Frontend Developer";
        job2._startYear = 2029;
        job2._endYear = 2038;


        Resume personResume = new Resume();
        personResume._personJob.Add(job1);
        personResume._personJob.Add(job2);
        personResume._personName = "Ntombi Hontyo";

       personResume.DisplayResume();       
    }
}