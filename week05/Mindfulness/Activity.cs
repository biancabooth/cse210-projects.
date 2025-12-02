public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description  = description;
        _duration = duration;
    }
    public virtual void DisplayStartingMessage()
    {
       Console.WriteLine($"Welcome to the {_name} activity\n");
       
       Console.WriteLine($"In this activity you will {_description}\n");
      
    }
    public virtual void DisplayEndingMessage()
    {
        Thread.Sleep(1000);
      Console.Write($"Well done! ");  
      ShowSpinner(4);
      Console.WriteLine($"You have completed {_duration} seconds of the {_name}");
      ShowSpinner(4);
    }
    public void ShowSpinner(int seconds)
    {
    
       List <string> spinnerString =new List<string>();
       spinnerString.Add("|");
       spinnerString.Add("/");
       spinnerString.Add("-");
       spinnerString.Add("\\");
       spinnerString.Add("|");
       spinnerString.Add("/");
       spinnerString.Add("-");
       spinnerString.Add("\\");

       foreach(string s in spinnerString)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        
        }

    }
    public void ShowCountDown(int seconds)
    {
      for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}