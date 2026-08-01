public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions;
    List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectingActivity()
    {
        _name = "reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";
        _duration = 10;
        _prompts = prompts;
        _questions = questions;
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int number = random.Next(_prompts.Count);
        return _prompts[number];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int number = random.Next(_questions.Count);
        return _questions[number];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine("");
    }
    public void DisplayQuestion()
    {
        Console.Write($"> {GetRandomQuestion()}");
        base.ShowSpinner(6);
    }
    public void Run()
    {
        base.DisplayStartingMessage();
        base.ShowSpinner(5);
        Console.WriteLine("Consider the following prompt");
        DisplayPrompt();
        int remainingSecond = _duration;
        Console.Write("Press enter when you have something in mind: ");
        base.ShowSpinner(5);
        string answer = Console.ReadLine();
        if (answer == "")
        {
            Console.WriteLine("Ponder on the following questions as they relate to your experience");
            Console.Write("You may begin in: ");
            base.ShowCountDownSecond(5);
            remainingSecond -= 5;
            Console.Clear();
            while (remainingSecond > 0)
            {
                DisplayQuestion();
                //Thread.Sleep(6000);
                remainingSecond -= 6;
            }
        }
        Console.WriteLine();
        Console.WriteLine();
        base.DisplayEndingMessage();
        base.ShowSpinner(7);
        Console.Clear();
    }

}