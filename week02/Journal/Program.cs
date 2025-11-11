using System;


class Program
{
    static void Main(string[] args)
    {
        int newAnswer = 0;
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        PromptGenerator aPrompt = new();
        //Do i need a list here or file name?

        do
        {
            Console.WriteLine("Welcome to the Journal Program! ");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.Write("What would you like to do? ");
            string answer = Console.ReadLine();
            newAnswer = int.Parse(answer);
            if (newAnswer == 1)
            {
                aPrompt.GetRandomPrompt();
                anEntry.Display();
                theJournal.AddEntry();
                theJournal.SaveToFile();
            }
            else if (newAnswer == 2)
            {
                theJournal.DisplayAll();
            }
            else if (newAnswer == 3)
            {
                theJournal.SaveToFile();
            }
            else newAnswer == 4;
            {
                theJournal.LoadFromFile();
            }
        } while (newAnswer != 5);
        
        

    }

}