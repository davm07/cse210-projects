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
        string[] lines = File.ReadAllLines(filename);

        if (lines.Length > 0) 
        {
            foreach (string line in lines)
            {   
            Entry loadEntry = new Entry();
            string[] parts = line.Split("**");
            string date = parts[0];
            string prompt = parts[1];
            string answer = parts[2];

            loadEntry._date = date;
            loadEntry._prompt = prompt;
            loadEntry._entry = answer;

            _entries.Add(loadEntry);
            }
        } else 
        {
            Console.WriteLine($"The file named: {filename} is empty, are you sure it's the correct one?");
        } 
    }

    public void SaveToFile(string filename)
    { 
        using( StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}**{entry._prompt}**{entry._entry}");
            }
        }
    }
    
}
