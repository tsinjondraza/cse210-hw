using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        string answer = "";
        do
        {
            Console.WriteLine("Menu options: ");
            Console.WriteLine(" 1- Start breathing activity");
            Console.WriteLine(" 2- Start reflecting activity");
            Console.WriteLine(" 3- Start listing activity");
            Console.WriteLine(" 4- Quit");
            Console.Write("Please select an item from the menu: ");
            answer = Console.ReadLine();
            choice = int.Parse(answer);
            if (choice == 1)
            {
                BreathingActivity newActivity = new();
                newActivity.Run();
            }
            else if (choice == 2)
            {
                ReflectingActivity reflect = new();
                reflect.Run();
            }
            else if (choice == 3)
            {
                ListingActivity list = new();
                list.Run();
            }
        }
        while (choice != 4);
    }
}