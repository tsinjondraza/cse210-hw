using static System.Runtime.InteropServices.JavaScript.JSType;
public class ListingActivity : Activity
{
    // private int _count;
    private List<string> _prompts;
    List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity()
    {
        _name = "listing";
        _description = "This activity will help you reflect on the many good things in your life by having you list as many things as you can in a certain area.";
        _duration = 10;
        _prompts = prompts;
    }
    private string GetRandomPrompt()
    {
        Random randomNumber = new Random();
        int number = randomNumber.Next(_prompts.Count);
        return _prompts[number];
    }
    public List<string> GetListFromUser()
    {
        List<string> listFromUser = new List<string>();
        DateTime currentTime = DateTime.Now;
        DateTime endDate = currentTime.AddSeconds(_duration);
        while (DateTime.Now < endDate)
        {
            string answer = Console.ReadLine();
            listFromUser.Add(answer);
        }
        return listFromUser;
    }
    public void Run()
    {
        base.DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        List<string> responses = GetListFromUser();
        Console.WriteLine($"You listed {responses.Count} items.");
        base.DisplayEndingMessage();
        Thread.Sleep(5000);
        Console.Clear();
    }
}