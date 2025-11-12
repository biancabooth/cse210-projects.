
using System.IO; 
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

public class Journal
{

    public List<Entry> _entries = new List<Entry>();

    

    public void AddEntry()
    {
        PromptGenerator pG = new PromptGenerator();
        Entry newEntry = new Entry();
        newEntry._date = DateTime.Now.ToShortDateString();
        newEntry._promptText = pG.GetRandomPrompt();
        Console.WriteLine(newEntry._promptText);
        newEntry._entryText = Console.ReadLine();
        _entries.Add(newEntry);

    }

    public void DisplayAll()
    {

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile()
    {
        string filename = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry line in _entries)
            {
                string value = $"{line._date}|{line._promptText}|{line._entryText}";
                outputFile.WriteLine(value);

            }
            Console.WriteLine("Entries saved. ");
        }
    }
    public void LoadFromFile()
    {
        Console.Write("What is the file name? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];
            Console.WriteLine($"{date}-{prompt}: {entry}");
        }
    }

}    
    

