public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points): base(name, description, points)
    {
        
    }
    public override void RecordEvent()
    {
            
        Console.WriteLine($"Congratulations! You have earned {_points} points. ");
       
        Console.WriteLine($"You know have {_points} points");

    }
    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        
        string stringRepresentation = $"EternalGoal:{_shortName}|{_description}|{_points}";
        return stringRepresentation;
    
    }
}

