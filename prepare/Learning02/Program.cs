using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "KFC";
        job1._jobTitle = "Manager";
        job1._startYear = 2017;
        job1._endYear = 2020;
        

        Job job2 = new Job();
        job2._company = "DARPA";
        job2._jobTitle = "Chief engineer";
        job2._startYear = 2020;
        job2._endYear = 2024;
        
        Resume r = new Resume();
        r._name = "Samuel Lambert";

        r._jobs.Add(job1);
        r._jobs.Add(job2);
        r.Display();
    }
}