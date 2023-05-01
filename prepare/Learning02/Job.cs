using System;
//Creating the Job class
public class Job 
{
    // Creating the member Variables
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // A special Method, called a constructor that is invoked using the
    // new keyword followed by the class name and parentheses.
    public Job() 
    {
    }

    // A method that displays the person's job title, company, and start
    // year and end year of the job position.
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}