using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment test1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(test1.GetSummary());

        MathAssignment testMath = new("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(testMath.GetSummary());
        Console.WriteLine(testMath.GetHomeworkList());

        WritingAssignment test2 = new("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(test2.GetSummary());
        Console.WriteLine(test2.GetWritingInformation());
    }
}