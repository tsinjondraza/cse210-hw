using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        DisplayWelcome();
        static string PromptUserName ()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        string userName = PromptUserName();
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string answer = Console.ReadLine();
            int userNumber = int.Parse(answer);
            return userNumber;
        }
        
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        int squareNumber = SquareNumber(PromptUserNumber());
        
        static void DisplayResult (string name, int number)
        {
            Console.WriteLine($"Brother/Sister {name}, the square of your number is {number}.");
        }
        DisplayResult(userName, squareNumber);

        
    }
}