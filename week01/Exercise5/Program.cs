using System;

class Program
{
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string answer = Console.ReadLine();
        int userNumber = int.Parse(answer);
        return userNumber;
    }
    
    static void DisplayResult (string name, int number)
        {
            Console.WriteLine($"Brother/Sister {name}, the square of your number is {number}.");
        }


    static void Main(string[] args)
    {
        
        DisplayWelcome();
        string userName = PromptUserName();
        int squareNumber = SquareNumber(PromptUserNumber());
        DisplayResult(userName, squareNumber);

        
    }
}