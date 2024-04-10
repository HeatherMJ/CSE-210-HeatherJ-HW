


namespace Develop05;

    public class GoalManager
    {
        private List<Goal> goals = new List<Goal>();
        private List<Goal> _goals; 
        private int _score;
        private int _totalPointsEarned;
        private readonly object saveToFile;
        private readonly Stream filename;

        public int TotalScore => _score;
        public int TotalPointsEarned => _totalPointsEarned;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
            _totalPointsEarned = 0;
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"Your Current score: {_totalPointsEarned}");
        }

        public void ListGoalNames()
        {
            Console.WriteLine("Here is your list of Goal Names");
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal._shortName);
            }
        }

        public void ListGoalDetails()
        {
            Console.WriteLine("Here are the details of the loaded goals:");
            foreach (var goal in _goals)
            {
                Console.WriteLine($"Name: {goal._shortName}, Description: {goal._description}");
            }
        }

        public void CreateNewSimpleGoal(string name, string description, int points)
        {
            Console.WriteLine("Creating a new simple goal....");
            _goals.Add(new SimpleGoal(name, description, points));
        }

        public void CreateNewEternalGoal(string name, string description, int points)
        {
            Console.WriteLine("Creating a new eternal goal....");
            _goals.Add(new EternalGoal(name, description, points));
        }
        public void CreateNewChecklistGoal(string name, string description, int points)
        {
            Console.WriteLine("Creating a new checklist.......");
            //_goals.Add(new CheckListGoal(name, description, points));
        }
        public void RecordEvent()
        {
            Console.WriteLine("Recording event...");
        }

        public void SaveGoals(string filename)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (var goal in _goals)
                    {
                        string goalString = $"{goal._shortName},{goal._description},{goal._points},{goal.IsComplete()}";
                        writer.WriteLine(goalString);
                        string stringGoal = goal.GetStringRepresentation(saveToFile);
                    }
                }
                Console.WriteLine("Goals saved successfully.");
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred while saving goals: {e.Message}");
            }
        }

        public void SaveGoals()
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] goalData = line.Split(',');

            }
        }
        Console.WriteLine("Goals loaded successfully.");
        }

        public void  LoadGoals()
        {
            using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] goalData = line.Split(','); 

               
                string name = goalData[0];
                string description = goalData[1];
                int points = int.Parse(goalData[2]);
            }    
        }
    }
}