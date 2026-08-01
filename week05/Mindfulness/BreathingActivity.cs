public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "breathing";
        _description = "This activity will help you relax by walking you through breathing in and breathing out. Clear your mind and focus on your breathing.";
        _duration = 10;
    }
    public void Run()
    {
        base.DisplayStartingMessage();
        
        int remainingSecond = _duration;
        base.ShowSpinner(3);

        while (remainingSecond > 0)
        {
            Console.Write("Breathe in ....");
            if (remainingSecond < 6)
            {
                break;
            }
            base.ShowCountDownSecond(6);
            Console.WriteLine("");
            remainingSecond -= 6;
            Console.Write("Breathe out ....");
            if (remainingSecond < 4)
            {
                break;
            }
            base.ShowCountDownSecond(4);
            remainingSecond -= 4;
            Console.WriteLine("");
            Console.WriteLine("");
        }
        base.DisplayEndingMessage();
        base.ShowSpinner(7);
        Console.Clear();

    }
}