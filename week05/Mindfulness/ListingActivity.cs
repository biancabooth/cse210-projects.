public class ListingActivity :Activity
{
    private int _count=0;
    private List<string> _prompt = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"

    };
     List <string> _userInput = new List<string>();
    Random _random = new Random();

    public ListingActivity(string name, string description,int duration): base(name,description,duration)
    {
        _name = name;
        _description  = description;
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
        
        
        foreach(string i in _userInput)
        {
            _count++;
            Console.WriteLine(i);
           
        }
        Console.WriteLine($"You listed {_count} items.");
        

    }

    
    public string GetRandomPrompt()
    {
        int randomPrompt = _random.Next(_prompt.Count);
       
        return _prompt[randomPrompt];
    }

    public List<string> GetListFromUser()
    {
        
       
        Console.Write("> ");
        string input = Console.ReadLine();
        _userInput.Add(input);
        return _userInput;


    }

    
}