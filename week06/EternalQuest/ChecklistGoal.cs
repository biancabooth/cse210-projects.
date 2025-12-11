public class ChecklistGoal : Goal
{
   protected int _amountCompleted;
   protected int _target;
   protected int _bonus;
   public ChecklistGoal(string name, string description, int point, int target, int bonus):base(name, description, point)
    {
       _target = target;
       _bonus = bonus; 
       _amountCompleted = 0;
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    public override int GetPoints()
    {
        if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }
        else
        {
            return _points;
        }
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted < _target)
        {
            Console.WriteLine($"You have completed {_amountCompleted}/{_target}.");
            Console.WriteLine(_points);

        }
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congratulation you have completed your goal! {_amountCompleted}/{_target} ⭐");
            
            Console.WriteLine($"You have {_points + _bonus} points. ");

        }
    }
   
   
    public override bool IsComplete()
    {
        return _amountCompleted>=_target;
    }
    public override string GetDetailsString()
    {
        string checkString = "";
        if (_amountCompleted == _target)
        {
           checkString =  $"[X] {_shortName}, {_description} -- Currently completed: {_amountCompleted}/{_target}";
        }
       else if (_amountCompleted < _target)
        {
            checkString = $"[ ] {_shortName}, {_description} -- Currently completed: {_amountCompleted}/{_target}";
            
        }
        
        return checkString;
    }
    public override string GetStringRepresentation()
    {
        string check = $"ChecklistGoal:{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
        return check;
    }

}