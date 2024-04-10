using System.IO;

namespace Develop05
{
    public class EternalGoal : Goal
    {
        private int _timesAttempted;
        
        public int TotalPointsEarned => _points * _timesAttempted;
        
        public EternalGoal(string name, string description, int points) : base(name, description, points)
        {
            _timesAttempted = 0; 
        }
        
        public override void RecordEvent()
        {
          
            _timesAttempted++;
        }
        
        public override bool IsComplete()
        {
            return false; 
        }
        
        public override string GetStringRepresentation()
        {
            return $"Eternal Goal: {_shortName}, Description: {_description}, Points: {_points}, Times Attempted: {_timesAttempted}";
        }
    }
}