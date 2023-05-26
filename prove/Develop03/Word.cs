using System;

public class Word 
{
    private string _word;
    private bool _isHidden;

    private static Random rnd = new Random();

    public Word(string word) 
    {
        _word = word;
        // How to choice a random boolean
        // https://www.loekvandenouweland.com/content/random-boolean-in-csharp.html#:~:text=If%20you%20want%20to%20create,Random()%3B%20var%20randomBool%20%3D%20random.
        _isHidden = rnd.Next(2) == 1;
    }

    // public string GetWord(){
    //     return _word;
    // }

    public string DisplayText()
    {
        if (_isHidden)
        {
            return _word;
        } else
        {   
            // I use that link to make sure that I was
            // multiplying correctly the string
            // https://www.delftstack.com/howto/csharp/csharp-repeat-string-x-times/
            return new string('_', _word.Length);
        }
    }
}