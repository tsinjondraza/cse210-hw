using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;


class Program
{
    static void Main(string[] args)


    {
        Journal myJournal = new Journal();
        string fileName;
        string fileToLoadFrom;
        PromptGenerator question = new PromptGenerator();
        string needAnswer;
        string choice;
        int answer = 0;
        string journalEntry = "";
        List<string> questions = new List<string>();
        questions.Add("What was the favorite time of your day? ");
        questions.Add("If you could, what activity will you do again tomorrow? ");
        questions.Add("Who contributed the most to your smiling today? ");
        questions.Add("Did you learn any new kind word today? ");
        questions.Add("What university teacher you got reminded of while executing tasks at work today? ");
        questions.Add("What old friend did you suddenly remember? ");
        do
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1-Write");
            Console.WriteLine("2-Display");
            Console.WriteLine("3-Load");
            Console.WriteLine("4-Save");
            Console.WriteLine("5-Quit");

            choice = Console.ReadLine();
            answer = int.Parse(choice);
            if (answer == 1)
            {
                DateTime currentDate = DateTime.Now;
                Entry response = new Entry();
                response._date = currentDate.ToShortDateString();
                question._prompts = questions;
                needAnswer = question.GetRandomPrompt();
                Console.WriteLine(needAnswer);
                response._promptText = needAnswer;
                journalEntry = Console.ReadLine();
                response._entryText = journalEntry;
                myJournal.AddEntry(response);

                 
            }
            else if (answer == 2) 
            {
                myJournal.DisplayAll();
            }
            else if (answer == 3)
            {
                Console.WriteLine("Which file do you want to open? ");
                fileToLoadFrom = Console.ReadLine();
                myJournal.LoadFromFile(fileToLoadFrom);
            }
            else if (answer == 4)
            {
                Console.Write("Which file do you wanna save these entries in? ");
                fileName = Console.ReadLine();
                myJournal.SaveToFile(fileName);
                
            }


        }
        while (answer != 5);
        
        
        
    }
}