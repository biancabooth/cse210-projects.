using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int number = int.Parse(percentage);
        string letter = "";
        string sign = "";
        int lastDigit = number % 10;
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
            
        }
        
        if (lastDigit == 7  && number <93)
            {
                sign = "+";
            }
        else 
        {   if (number>59 && number <97)
            {
                sign = "-";
            }
        }
        Console.WriteLine($"Your grade is {letter}{sign}");

        if (number >= 70)
        {
            Console.Write("Congratulations, you passed!");
        }
        else 
        {
            Console.Write("You didn't pass, trt again next time.");
        }
            

    }
}