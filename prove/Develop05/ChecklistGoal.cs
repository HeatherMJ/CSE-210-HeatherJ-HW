using System.IO; 
using System;

namespace Develop05
{
    public class CheckListGoal: Goal
    {
        private int _amountCompleted;
        private int _earnedPoints;
        private int _target;
        private int _bonus;
        public CheckListGoal(string name, string description,int points, int target, int bonus): base(name, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }
        public override void RecordEvent()
        {
            _amountCompleted++;
            _earnedPoints += _points;
            if (_amountCompleted == _target)
            {
            _earnedPoints += _bonus;
            }
        }  
        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }
        public override string GetStringRepresentation()
        {
            return $"Checklist Goal: {_shortName}, Description: {_description}, Points: {_points}, Completed: {_amountCompleted}/{_target}";
        }
    }
}
        
    
   
       