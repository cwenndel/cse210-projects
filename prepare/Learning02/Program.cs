using System;


class Job
{   
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;
}

class Resume
{
    public List<Job> _jobs;

    public string _name;
    public Resume()
    {
        _jobs = new List<Job>();
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        foreach (Job job in _jobs)
        {   
            Console.WriteLine($"Job Title: {job._jobTitle}");
            Console.WriteLine($"Company: {job._company}");
            Console.WriteLine($"Start Year: {job._startYear}");
            Console.WriteLine($"End Year: {job._endYear}");
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1. _jobTitle = "Software Engineer";
        job1. _company = "Microsoft";
        job1. _startYear = 2022;
        job1. _endYear = 2023;
        Job job2 = new Job();
        job2. _jobTitle = "Manager";
        job2. _company = "Apple";
        job2. _startYear = 2022;
        job2. _endYear = 2023;

        Resume firstResume = new Resume();
        firstResume._name="Allison Rose";
        firstResume. _jobs.Add(job1);
        firstResume. _jobs.Add(job2);

        firstResume.Display();
    }
}