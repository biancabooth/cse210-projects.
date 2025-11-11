
using System.IO; 
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

public class Journal
{

    public List<Entry> _entries = new List<Entry>();

    

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
    public void SaveToFile(List<Entry>_entries)
    {
        string filename = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
                foreach (Entry line in _entries)
            {
                string value = $"{line._date}|{line._promptText}|{line._entryText}";
                outputFile.WriteLine(value);
            }
        }
    }
    public  List <Entry> LoadFromFile(string file)
    {
        Console.Write("What is the file name? ");
        string filename = Console.ReadLine();
        filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        return _entries;
    }

}    
    

