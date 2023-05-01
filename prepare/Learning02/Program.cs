using System;

class Program
{
    static void Main(string[] args)
    {   
        // Creating a new instance of the Job class and setting the
        // member variables using the dot notation
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Creating a new instance of the Job class and setting the
        // member variables using the dot notation
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Creating a new instance of the Resume class, setting the _name
        // variable, adding the job information from the job objects to
        // the Resume List, and displaying the information with the 
        // DisplayResume() method
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResume();

    }   
}