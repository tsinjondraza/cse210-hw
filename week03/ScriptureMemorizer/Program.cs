using System;

class Program
{
    static void Main(string[] args)
    {
        string book = "Exodus";
        int chapter = 20;
        int startVerse = 4;
        int endVerse = 6;
        string content = "Thou shalt not make unto thee any graven image, or any likeness of any thing that is in heaven above, or that is in the earth beneath, or that is in the water under the earth: 5Thou shalt not bow down thyself to them, nor serve them: for I the Lord thyGod am a jealous God, visiting the iniquity of the fathers upon the children unto the third and fourth generation of them that hate me; 6and shewing mercy unto thousands of them that love me, and keep my commandments.";

        Reference scriptureIndex = new(book, chapter, startVerse, endVerse);
        Scripture scriptureVerse = new(scriptureIndex, content);

        string choice = "";
        string displayText = scriptureVerse.GetDisplayText();
        string newText = displayText;
        
        while (choice != "quit")
        {
            Console.WriteLine(newText);
            scriptureVerse.HideRandomWords(5);
            newText = scriptureVerse.GetDisplayText();

            Console.Write("Press enter or type quit to end the program:");
            choice = Console.ReadLine();

            if (scriptureVerse.IsCompletelyHidden())
            {
                choice = "quit";
            }
            Console.Clear();

        }
    }
}