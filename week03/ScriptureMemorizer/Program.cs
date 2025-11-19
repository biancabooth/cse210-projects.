using System;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference verses = new Reference("Romans",8,38,39);
        Console.WriteLine(verses.GetDisplayText());
        Scripture scripture = new(verses,"38 For I am persuaded, that neither death, nor life, nor angels, nor principalities, nor powers, nor things present, nor things to come, 39 Nor height, nor depth, nor any other creature, shall be able to separate us from the love of God, which is in Christ Jesus our Lord.");
        Console.WriteLine(scripture.GetDisplayText());
        string input = "";
       
        while (input != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
   
            if(scripture.IsCompletelyHidden())
            {
                break;
            }
            scripture.HideRandomWords(3);
            Console.WriteLine("Press enter to continue: ");
            input = Console.ReadLine();
        }
    }
}