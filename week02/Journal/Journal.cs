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
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
                sw.WriteLine($"{e._date}||{e._prompt}||{e._entry}");
            }
        }

    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine($"Sorry, the file '{file}' does not exist.");
        }
        else
        {
             _entries.Clear();
            string[] lines = System.IO.File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split("||");
                if(parts.Length == 3)
                {
                    Entry newEntry = new Entry();
                    newEntry._date = parts[0];
                    newEntry._prompt = parts[1];
                    newEntry._entry = parts[2];

                    _entries.Add(newEntry);
                }
            }
        }
       
    }
}