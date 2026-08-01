using static System.Runtime.InteropServices.JavaScript.JSType;
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity()
    {
        _name = "this activity";
        _description = "This activity will help you relax.";
        _duration = 20;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        string answer = Console.ReadLine();
        _duration = int.Parse(answer);
        Console.WriteLine("");
        Console.WriteLine("Get ready ....");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity.");
    }
    public void ShowCountDownSecond(int sec)
    {
        for (int i = sec; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowSpinner(int sec)
    {
        List<string> animationStrings = new List<string>
        {
            "|",
            "\\",
            "_",
            "/"
        };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(sec);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

}