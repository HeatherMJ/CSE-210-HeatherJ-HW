using System.IO; 
public abstract class Goal
{
    private string _shortName;
    private string _descriptions;
    private int _points;
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _descriptions = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool ISComplete();
    public abstract string GetStringRepresentation();
}
