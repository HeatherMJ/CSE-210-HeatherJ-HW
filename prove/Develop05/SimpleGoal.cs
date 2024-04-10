using System;

namespace Develop05
{   
    public class SimpleGoal : Goal
    {
        private bool _IsComplete;
        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
            _IsComplete = false; 
        }
        
        public override void RecordEvent()
        {
            _IsComplete = true; 
        }
        
        public override bool IsComplete()
        {
            return _IsComplete; 
        }        
        public override string GetStringRepresentation()
        {
             return $"{_shortName}, {_description}, {_points}, {IsComplete()}";
        }
    }

}
        