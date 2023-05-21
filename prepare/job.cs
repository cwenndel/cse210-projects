using System;

class Program


{
    public class Job{
        public string _jobTitle;
        public string _company;
        public int _startYear;
        public int _endYear;
        
    }
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} {_company} {_startYear} {endYear}");
    }

    public Job(string _jobTitle)
    {
        _jobTitle = jobTitle;
    }


    public class Resume{
        public string _name;
        public string _job;
    }

    public resume(string _name);
}

