using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("03 Nov 2022", 30, 4.8);
        running.GetSummary();

        Swimming swimming = new Swimming("05 Oct 2023", 50, 15);
        swimming.GetSummary();

        Cycling cycling = new Cycling("11 Jul 2023", 40, 27);
        cycling.GetSummary();
    }
}