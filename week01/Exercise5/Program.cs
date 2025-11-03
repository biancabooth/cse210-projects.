using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        SquareNumber(number);
        DisplayResult(name, SquareNumber(number));
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter yor name: ");
            string PromptUserName = Console.ReadLine();
            return PromptUserName;
        }
         static int PromptUserNumber()
        {
            Console.Write("Please enter you favorite number: ");
            string favoriteNumber = Console.ReadLine();
            int PromptUserNumber = int.Parse(favoriteNumber);
            return PromptUserNumber;
        }
        static int SquareNumber(int PromptUserNumber)
        {
            int SquareNumber = PromptUserNumber * PromptUserNumber;
            return SquareNumber;
        }
        static void DisplayResult(string PromptUserName, int SquareNumber)
        {
            Console.WriteLine($"{PromptUserName}, the square of your favorite number is {SquareNumber}.");
        }
            
        
    }
}