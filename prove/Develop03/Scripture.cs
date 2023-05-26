using System;

public class Scripture
{
    private string _scriptureText;
    private Reference _scripReference;
    // private Word _wordHide;

    private static Random rnd = new Random();

    public Scripture() 
    {
        _scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        _scripReference = new Reference("Proverbs", 3, 5, 6);
        // _wordHide = new Word(text);
    }

    public string MakeScripture()
    {
        return $"{_scripReference.MakeReference()} {_scriptureText}";
    }

    public List<string> MakeList()
    {
        List<string> words = _scriptureText.Split(" ").ToList();
        return words; 
    }

    public string CreateHiddenScrip(List<string> words)
    {   
        for (int i = 0; i < words.Count; i++)
        {   
            Word wordTohide = new Word(words[i]);
            string hiddenword = wordTohide.DisplayText();
            words[i] = hiddenword;
            
        }

        _scriptureText = string.Join(" ", words);
        return _scriptureText;
    }

    // public bool IsCompletelyHidden() 
    // {
        
    // }
    
}