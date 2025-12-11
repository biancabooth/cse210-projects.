public abstract class Goal
{
   protected string _shortName;
   protected string _description;
   protected int _points;

   public Goal(string name, string description, int points)
   {
        _shortName = name;
        _description = description;
        _points = points;
   }
   public string GetShortName()
    {
        return _shortName;
    } 
    public void SetShortName(string shortName)
    {
        _shortName = shortName;
    }
    public virtual int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
       _points = points; 
    }

   public abstract void RecordEvent();
   public abstract bool IsComplete();

   public virtual string GetDetailsString()
    {
        
        string checkBox;
        if (IsComplete())
        {
            checkBox = "[X]";
        }
        else
        {
            checkBox = "[]";
        }
        return $"{checkBox} {_shortName} , {_description}";
    }

    public abstract string GetStringRepresentation();
    

}