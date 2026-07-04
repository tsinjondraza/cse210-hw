using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string playAgain = "yes"; 
        while (playAgain == "yes")
        {
        int mysteriousNumber = randomGenerator.Next(1, 101);
        int guess;
        int attemptNumber = 0;
        do 
        {
        Console.Write("Give your guess: ");
        string answer = Console.ReadLine();
        guess = int.Parse(answer);
        if (guess > mysteriousNumber)
        {
            Console.WriteLine("Lower");
            attemptNumber ++;
        }
        else if (guess < mysteriousNumber)
        {
            Console.WriteLine("Higher");
            attemptNumber ++;
        }
        else
        {
            Console.WriteLine("Congratulations! You guessed it.");
            Console.WriteLine($"It took you {attemptNumber} tries to get it.");
            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        }
        } 
        while (guess != mysteriousNumber);
        }

    }
}