using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    private string _journalDirectory = @"C:\Journal\";

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("Date: " + entry._date);
            Console.WriteLine(entry._message);
        }
    }

    public List<Entry> Load()
    {
        // implement loading from a file
        return null;
    }

    public void Save()
    {
        // implement saving to a file
    }

    public void AddEntry(string filename)
    {
        Entry entry = new Entry();
        entry.Write();
        string filePath = _journalDirectory + filename + ".txt";
        Directory.CreateDirectory(_journalDirectory);
        File.WriteAllText(filePath, entry.ToString());
    }
}
