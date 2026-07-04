using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);
        string finalGrade = "";
        
        if (grade >= 90)
        {
            finalGrade = "A";  
        }
        else if (grade >= 80)
        {
            finalGrade = "B";
        }
        else if (grade >= 70)
        {
            finalGrade = "C";
            Console.WriteLine("yes");
        
        }
        else if (grade >= 60)
        {
            finalGrade = "D";
        }
        else
        {
            finalGrade = "F";
        }
        Console.WriteLine($"You had an {finalGrade}.");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulation on making it!");
        }
        else
        {
            Console.WriteLine("Please don't be discouraged. Try again next semester!");
        }

    }
}