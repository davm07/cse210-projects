using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,101);
        int guessNumber = 0;
        int contador = 0;
        
        
        while (guessNumber != randomNumber)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);
            contador++;

            if (guessNumber == randomNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {contador} times");
                }

            else if (guessNumber < randomNumber)
            {
                Console.WriteLine("Higher!");
            }

            else if (guessNumber > randomNumber)
            {
                Console.WriteLine("Lower!");
            }
        }

    }
}