using System;
// Creating the Resume class
public class Resume 
{
    // Creating the member variables
    public string _name;
    // Inializing the list to a new list before using it
    public List<Job> _jobs = new List<Job>();

    // A method that displays the name of the person and using a loop
    // iterates to every job information that this person had.
    public void DisplayResume ()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }

    }

}