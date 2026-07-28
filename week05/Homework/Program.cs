using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new("Geometry", "Emaneke");
        //Console.WriteLine(assignment.GetSummary());
        MathAssignment myMathAssignment = new("17", "1-6", "Emaneke", "Geometry");
        //Console.WriteLine(myMathAssignment.GetSummary());
        //Console.WriteLine(myMathAssignment.GetHomeWorkList());
        WrittingAssignment myWrittingAssignment = new("Emaneke", "The creation", "Earth");
        Console.WriteLine(myWrittingAssignment.GetSummary());
        Console.WriteLine(myWrittingAssignment.GetWrittingInformation());
    }
}