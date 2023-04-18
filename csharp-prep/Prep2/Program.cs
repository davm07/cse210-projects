using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        float gradePercentage = float.Parse(grade);
         string letter = "";

        if (gradePercentage >= 90) 
        {
            letter = "A";
        }
        else if (gradePercentage >= 80) 
        {
            letter = "B";
        }
        else if (gradePercentage >= 70) 
        {
            letter = "C";
        }
        else if (gradePercentage >= 60) 
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (gradePercentage >= 70) 
        {
            Console.WriteLine("Congratulations you passed the course!");
        }

        else 
        {
            Console.WriteLine("Sorry your grades are not enough. Keep studying!");
        }

    }
}