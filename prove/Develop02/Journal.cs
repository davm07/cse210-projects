using System;
using System.IO;
public class Journal 
{   
    public List<Entry> _entries = new List<Entry>();
    
    public void AddEntry(Entry entry)
    {   
        _entries.Add(entry);
    }

    public void DisplayEntry()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntryInfo();
            Console.WriteLine();
        }
    }

    public void LoadFromFile(string filename)
    {
        
    }

    public void SaveToFile(string filename)
    { /*
        using( StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {_date.ToShortDateString()} - Prompt: {_prompt}");
                outputFile.WriteLine(_entry);
            }
        }*/

    }


    
}
