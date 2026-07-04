using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string answer;
        int number;
        do 
        {
            Console.Write("Please enter a number. Type 0 when done: ");
            answer = Console.ReadLine();
            number = int.Parse(answer);
            if (number != 0)
            {
            numbers.Add(number); 
            }            
        }
        while (number != 0);

        int sum = 0;
        int highestNumber = 0;
        foreach (int element in numbers)
        {
            sum += element;
            if (element > highestNumber)
            {
                highestNumber = element;
            }
        }
        
        
        Console.WriteLine($"The highest number is {highestNumber}."); 
        Console.WriteLine($"The total is {sum}.");
        Console.WriteLine($"The average is {((float)sum) / numbers.Count}.");   
        
    }
}