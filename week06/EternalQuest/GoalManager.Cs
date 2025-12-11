using System.Reflection.Metadata.Ecma335;
using System.IO; 
public class GoalManager 
{
    protected List <Goal> _goals = new List<Goal>();
    protected int _score= 0;

    public GoalManager()
{
    _goals = new List<Goal>();
    _score = 0;
}

    public void Start()
    {  int userInput = 0;
        do{
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goal");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string input = Console.ReadLine();
            userInput = int.Parse(input);
            if (userInput == 1)
            {
                CreateGoal();
            }
            if (userInput == 2)
            {
                ListGoalNames();
            }
            if (userInput == 3)
            {
                SaveGoals();
            }
            if (userInput == 4)
            {
                LoadGoals();
            }
            if (userInput == 5)
            {
                RecordEvent();
            }
    }
    while (userInput != 6);
      
  
    }
    public void DisplayPlayerInfo()
    {
        //_score += _points;?
        Console.WriteLine($"Display {_score} points");
    }
    public void ListGoalNames()
    {
    
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"The goals are: {goal.GetShortName()}");
        }
    }
    public void ListGoalDetails()
    {
        int index = 1;
        Console.WriteLine("The goals are: ");
       foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        } 
    }
    public void CreateGoal()
    {
       Console.WriteLine($"The types of goals are: "); 
       Console.WriteLine($"1. Simple Goal"); 
       Console.WriteLine($"2. Eternal Goal");
       Console.WriteLine($"3. Checklist Goal"); 
       Console.WriteLine($"Which type of Goal would you like to create?: "); 
       string  goal = Console.ReadLine();
       int goalNumber = int.Parse(goal);
       if (goalNumber == 1 )
        {
            
            Console.WriteLine($"What is the name of your goal?"); 
            string name1 = Console.ReadLine();
            Console.WriteLine($"What is a short description of it? ");
            string description1 = Console.ReadLine(); 
            Console.WriteLine($"What is the amount of points associated with this goal? ");
            string sPoint = Console.ReadLine(); 
            int  points1 = int.Parse(sPoint);
            SimpleGoal goal1 = new SimpleGoal(name1,description1,points1);
            _goals.Add(goal1);
            
        }
        if (goalNumber == 2)
        {
            Console.WriteLine($"What is the name of your goal?"); 
            string name2 = Console.ReadLine();
            Console.WriteLine($"What is a short description of it? ");
            string description2 = Console.ReadLine(); 
            Console.WriteLine($"What is the amount of points associated with this goal? ");
            string sPoint = Console.ReadLine(); 
            int  points2 = int.Parse(sPoint);
            EternalGoal goal2 = new EternalGoal(name2,description2,points2);
            _goals.Add(goal2);
        }
        if (goalNumber == 3)
        {
            Console.WriteLine($"What is the name of your goal?"); 
            string name3 = Console.ReadLine();
            Console.WriteLine($"What is a short description of it? ");
            string description3 = Console.ReadLine(); 
            Console.WriteLine($"What is the amount of points associated with this goal? ");
            string sPoint = Console.ReadLine(); 
            int  points3 = int.Parse(sPoint);
            Console.WriteLine($"How many times does this goal need to be accomplished for a bonus? ");
            string b = Console.ReadLine(); 
            int times3 = int.Parse(b);
            Console.WriteLine($"What is the bonus from accomplishing it that many times? "); 
            string timesBonus = Console.ReadLine();
            int bonus3 = int.Parse(timesBonus);
           ChecklistGoal goal3 = new ChecklistGoal(name3,description3,points3,times3,bonus3);
            _goals.Add(goal3);
        }
    }  
    public void RecordEvent()
    {
       ListGoalDetails();
        Console.WriteLine($"What goal did you accomplished? ");
        int index = int.Parse(Console.ReadLine())-1;
        Goal completedGoal = _goals[index];
        completedGoal.RecordEvent();
        int earned = completedGoal.GetPoints();
        _score += earned;
         Console.WriteLine($"You earned {earned} points!");
        Console.WriteLine($"Your total score is now {_score}.");
    }
    public void SaveGoals()
    {
        Console.WriteLine($"What is the filename for the goal file? ");
        string fileName= Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Goal g in _goals)
            {
               outputFile.WriteLine( g.GetStringRepresentation());
            }
        
        }
    }
    public void LoadGoals()
    {
        Console.WriteLine("What is the name in the file?");
        string fileName= Console.ReadLine();

        _goals.Clear();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string data = parts[1];
            string[] secondSplit = data.Split("|");
            string name = secondSplit[0];
            string description = secondSplit[1];
            int points = int.Parse(secondSplit[2]);
            
            if (goalType == "SimpleGoal")
            {   
                bool isComplete = bool.Parse(secondSplit[3]);
                SimpleGoal goalSimple = new SimpleGoal(name,description,points);
                goalSimple.SetComplete(isComplete);
                _goals.Add(goalSimple);
                ListGoalDetails();
            
                
            }
             if (goalType == "EternalGoal")
            {
              
                EternalGoal goalEternal = new EternalGoal(name,description,points);
                _goals.Add(goalEternal); 
                 ListGoalDetails();
            
            }
             if (goalType == "ChecklistGoal")
            {
                
                int amountCompleted = int.Parse(secondSplit[3]);
                int target = int.Parse(secondSplit[4]);
                int bonus = int.Parse(secondSplit[5]);
                ChecklistGoal goalChecklist = new ChecklistGoal(name,description,points,target,bonus);
                goalChecklist.SetAmountCompleted(amountCompleted);
                _goals.Add(goalChecklist);
                 ListGoalDetails();
            
                
            }
           
        }
        
    }



}