using System;

public class Activity
{   
    private string _name;
    private int _laps;
    public Activity(string name, int laps)
    {
        this._name = name;
        this._laps = laps;
    }

    public double Distance()
    {   
        return this._laps * 50 / 1000D; // esa D se llama real literal, buscar mas info sobre eso
        
    }

}