using System.ComponentModel;
using System.IO; 
#pragma warning disable CA1050 // Declare types in namespaces
public class SimpleGoal : Goal
#pragma warning restore CA1050 // Declare types in namespaces
{
    public SimpleGoal(string name, string description, int point)
{
    
}

    

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }

    public override bool ISComplete()
    {
        throw new NotImplementedException();
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
}