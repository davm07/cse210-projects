using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = -1;
        float total = 0;
        int maxNumber = 0;
        int minNumber = 100000000;

        while (number != 0)
        {   
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            
            if (number != 0)
            {
                total += number;
                numbers.Add(number);
            }
        }

        float average = total / (numbers.Count);
        foreach (int numberMax in numbers)
        {
            if (numberMax > maxNumber) 
            {
                maxNumber = numberMax;
            }
        }

        foreach (int numberMin in numbers)
        {
            if (numberMin > 0 && numberMin < minNumber) 
            {
                minNumber = numberMin;
            }
        }

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
        Console.WriteLine($"The smallest positive number is: {minNumber}");
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int sortedNumber in numbers)
        {
            Console.WriteLine(sortedNumber);
        }
        
    }
}