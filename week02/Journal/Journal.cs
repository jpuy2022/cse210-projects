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
}