using System.Data;
using System;
using System.Collections.Generic;
using System.Numerics;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        int number = -1;
        int sum = 0;
        int highestNumber = -1;
        List<int> numbers = new List<int>();
        while (number != 0)
        {
            Console.WriteLine("Please enter a number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number);

            }
        }
        foreach (int i in numbers)
        {
            sum += i;
            int oneNumber = i;
            if (i > highestNumber)
            {
                highestNumber = i;
            }
        }

        float average = (float)sum / numbers.Count;

        Console.WriteLine($"The total is: {sum}");
        Console.WriteLine($"The average is: {average}"); 
        Console.WriteLine($"The highest number is: {highestNumber}");
    }
}


    







    



