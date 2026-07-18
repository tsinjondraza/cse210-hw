using System.IO;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");
        foreach(string word in words)
        {
            Word newWord = new(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int i = 0;
        int randomIndex;
        Random rand = new Random();

        for (i = 0; i < numberToHide; i++)
        {
            randomIndex = rand.Next(0, _words.Count);
            Word wordToBeReplaced = _words[randomIndex];
            if (wordToBeReplaced.IsHidden())
            {
                i--;
            }
            else
            {
                wordToBeReplaced.Hide();
            }
            
        }
    }

    public string GetDisplayText()
    {
        string verseContent = "";
        foreach (Word word in _words)
        {
            verseContent += " " + word.GetDisplayText();
        }
        string textToDisplay = $"{_reference.GetDisplayText()}: {verseContent}";
        return textToDisplay;
    }

    public bool IsCompletelyHidden()
    {
        int hiddenWords = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                hiddenWords++;
            }
        }
        return hiddenWords == _words.Count;
    }

}