
using System.IO; 
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

public class Journal
{

    public List<Entry> _entries = new List<Entry>();

    public string[] lines = System.IO.File.ReadAllLines(filename);




    public void AddEntry(string date, string promptText, string entryText)
    {
        Entry newEntry = new Entry();
        newEntry._date = date;
        newEntry._promptText = promptText;
        newEntry._entryText = entryText;
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        string filename = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_entries);
        }
    }
    public void LoadFromFile(string file)
    {
        Console.Write("What is the file name? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename)){
            string[] lines = System.IO.File.ReadAllLines(filename);
            _entries.Clear();
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                string _date = parts[0];
                string _promptText = parts[1];
                string _entryText = parts[2];
            }
            _entries.Add(entry);
        }
    }

}    
    

