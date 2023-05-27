using System;

public class Word 
{
    private string _word;
    private bool _isHidden;

    private static Random rnd = new Random();

    public Word(string word) 
    {
        _word = word;
        _isHidden = false;
        // How to choice a random boolean
        // https://www.loekvandenouweland.com/content/random-boolean-in-csharp.html#:~:text=If%20you%20want%20to%20create,Random()%3B%20var%20randomBool%20%3D%20random.
        
    }

    // public string GetWord(){
    //     return _word;
    // }
    // public bool HideNotHide()
    // {
    //     _isHidden = rnd.Next(2) == 1;
    //     return _isHidden;
    // }

    public void Hide()
    {   
        _isHidden = true;
    }

    // public bool IsHidden(){
    //     _isHidden = true;
    //     if(_word == Hide())
    //     {
    //         _isHidden = true;
    //     }
    //     else
    //     {
    //         _isHidden = false;
    //     }

    //     return _isHidden;
    // }

    // public string GetWord()
    // {
    //     return _word;
    // }

    public void UnHide()
    {
        _isHidden = false;
    }

    public bool IsHiden()
    {
        return _isHidden;
    }

    public string DisplayText()
    {
        if (_isHidden)
        {
            return  new string('_', _word.Length);
        } 
        else
        {   
            // I use that link to make sure that I was
            // multiplying correctly the string
            // https://www.delftstack.com/howto/csharp/csharp-repeat-string-x-times/
            return _word;
        }
    }
}