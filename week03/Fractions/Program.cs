using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction sansNum = new Fraction();
        sansNum.SetTopNumber(10);
        Console.WriteLine(sansNum.GetTopNumber());
        
    }
}