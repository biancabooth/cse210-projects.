public class BreathingActivity :Activity
{
    public BreathingActivity (string name,string description, int duration):base(name,description,duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public override void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"This activity will {_description}"); 
    }
    public void DisplayEndingMessage(int seconds)
    {
        Thread.Sleep(1000);
        Console.Write($"Well done! ");  
        ShowSpinner(4);
        Console.WriteLine($"You have completed {seconds} seconds of the {_name}");
        ShowSpinner(4);

    }
   public void Run()
    {
        
        Console.Write("Breath in...");
        for (int i=4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }
        Console.WriteLine();
        Console.Write("Breath out...");
        for (int i=6; i>0; i--)
        {
           Console.Write(i);
           Thread.Sleep(1000); 
           Console.Write("\b \b");
           
        }
        Console.WriteLine("");
        
        
    } 
}