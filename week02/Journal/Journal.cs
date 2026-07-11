using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry text in _entries)
        {
            text.Display();
        }
    }
    public void SaveToFile(string file)
    {
        Console.WriteLine($"Saving your entries to {file} ...");
        using (StreamWriter OutputFile = new StreamWriter(file))
        {
            foreach (Entry text in _entries)
            {
                OutputFile.Write(text._date);
                OutputFile.WriteLine(text._promptText);
                OutputFile.WriteLine(text._entryText);
                OutputFile.WriteLine("");
            }
            
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        Console.WriteLine($"Loading from {file} ...");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    


}