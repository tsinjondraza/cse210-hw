
using System.Collections.Generic;
public class PromptGenerator
//if 1 is selected (means entry, so one of the five questions is )
//a code is then executed 
{
    public List<String> _prompts = new List<String>();
    public string GetRandomPrompt()
    {
    int randomIndex = Random.Shared.Next(_prompts.Count);
    string randomPrompt = _prompts[randomIndex];
    return randomPrompt;

    }   
    
}
