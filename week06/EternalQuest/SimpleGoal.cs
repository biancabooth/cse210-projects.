public class SimpleGoal:Goal
{
    protected bool _isComplete = false;

    public SimpleGoal(string name, string description, int points):base(name,description,points)
    {

       
    }
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            
            Console.WriteLine($"Congratulations! You have earned {_points} points. ");
            
            Console.WriteLine($"Now you have {_points} points");
            
        }
        else 
        {
            Console.WriteLine("You already completed this goal.");
            
        }

    }
    public void SetComplete(bool value)
    {
        _isComplete =value;
    }

    public override bool IsComplete()
    {
       
        return _isComplete;
        
    }

    public override string GetStringRepresentation()
    {
        
        string stringRepresentation = $"SimpleGoal:{_shortName}|{_description}|{_points}|{IsComplete()}";
        return stringRepresentation;
    }
}