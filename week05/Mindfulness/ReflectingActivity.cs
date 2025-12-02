public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."  

    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public Random _random = new Random();

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
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
       DisplayQuestion(); 
       ShowSpinner(18);
    }
    public string GetRandomPrompt()
    {
        int randomPrompt = _random.Next(_prompts.Count);
       
        return _prompts[randomPrompt];
    }
    public string GetRandomQuestion()
    {
       int randomQuestion = _random.Next(_questions.Count);
       return _questions[randomQuestion]; 
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"--{GetRandomPrompt()}--");
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }





}