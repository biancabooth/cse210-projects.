using System;
using System.Formats.Asn1;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do
        {
            Console.WriteLine("Hello World! This is the Exercise3 Project.");
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);
            int guessNumber = 0;
            int count = 0;

            while (guessNumber != magicNumber)
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
                count++;


                if (guessNumber < magicNumber)

                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else
                {
                    Console.WriteLine($"You guessed it!You guessed in {count} counts. ");

                }


            }
           
                Console.WriteLine("Do you want to play again?");
                response = Console.ReadLine();
        } while (response == "yes");
            
    }
}