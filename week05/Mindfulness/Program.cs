using System;
using System.Dynamic;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        int choice = 0;
        do
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1.Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start Listing activity ");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string firstAnswer = Console.ReadLine();
            choice = int.Parse(firstAnswer);
            if (choice == 1)
            {
                BreathingActivity choice1 = new BreathingActivity("Breathing Activity","help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. ",5);
                choice1.DisplayStartingMessage();
                Console.Write("How long in seconds, would you like for your session? ");
                string seconds = Console.ReadLine();
                Console.WriteLine("Get ready...");
                choice1.ShowSpinner(6);
                int durationSeconds = int.Parse(seconds);  
                int cycleBreathing = 10;
                int cycle = durationSeconds / cycleBreathing;
                for(int i = cycle; cycle>0; cycle--)
                {
                    choice1.Run();
                }
                
                choice1.DisplayEndingMessage(durationSeconds);
               

            }
            if (choice == 2)
            {
                ReflectingActivity reflecting1 = new ReflectingActivity("Reflecting Activity",  "help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 6);
                reflecting1.DisplayStartingMessage();
                Console.Write("How long in seconds, would you like for your session? ");
                string seconds = Console.ReadLine();
                int durationSeconds = int.Parse(seconds);
                while (durationSeconds<30)
                {
                    Console.WriteLine("Add more seconds");
                    Console.Write("How long in seconds, would you like for your session? ");
                    durationSeconds = int.Parse(Console.ReadLine());

                }

                    Console.WriteLine("Get ready...");
                    reflecting1.ShowSpinner(6);
                    
                    DateTime startTime = DateTime.Now;
                    DateTime endTime = startTime.AddSeconds(durationSeconds);  
                    reflecting1.DisplayPrompt();
                    Console.WriteLine("When you have something in mind, press enter to continue");
                    Console.ReadLine();
                    Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
                    Thread.Sleep(3000);
                    Console.WriteLine("You may begin in: ");
                    reflecting1.ShowCountDown(5);
                    while (DateTime.Now < endTime)
                    {
                        reflecting1.Run();
                    }
                    
                    reflecting1.DisplayEndingMessage(durationSeconds);   
                    

            }
            if (choice == 3)
            {
                ListingActivity listing1 = new ListingActivity("Listing Activity","help you reflect on the good things in your life by having you list as many things as you can in a certain area. ",5);
                listing1.DisplayStartingMessage();
                Console.Write("How long in seconds, would you like for your session? ");
                string seconds = Console.ReadLine();
                int durationSeconds = int.Parse(seconds);
                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(durationSeconds);  
                Console.Write("Get ready: ");
                listing1.ShowSpinner(6);
                Console.WriteLine();
                Console.WriteLine(listing1.GetRandomPrompt());
                Thread.Sleep(1000);
                Console.WriteLine("Enter a list from this prompt: ");
                
        
                 while (DateTime.Now < endTime)
                {
                    listing1.GetListFromUser();
                }
                
                listing1.Run();
                listing1.DisplayEndingMessage(durationSeconds);
                 
                
            }
           


        }while (choice != 4);
        

    }
}