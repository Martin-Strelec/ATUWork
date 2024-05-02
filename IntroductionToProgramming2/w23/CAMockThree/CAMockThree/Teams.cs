using System.Runtime.CompilerServices;
using System.Xml.XPath;

namespace QTeam
{
    public class Team
    {
        private string _name;
        private int _gScored;
        private int _gConceded;
        private int _nuOfMatches;
        private int _totalPoints;
        static private int _teamID;

        public string Name { get; }
        public int GScore { get; }
        public int NuOfMatches { get; }
        public int GConceded { get; }

        public int TotalPoints
        {
            get { return _totalPoints; }
            set
            {
                if (value < 0)
                {
                    _totalPoints = 0;
                }
                else
                {
                    _totalPoints = value;
                }
            }
        }

        public Team()
        {
            _name = "None";
        }

        public Team(string n, int id)
        {
            _name = n;
            _teamID = id;
        }

        public void AddMatchResult(int goalsTaken, int goalsGiven)
        {
            _nuOfMatches++;
            _gScored += goalsGiven;
            _gConceded += goalsTaken;
            if (goalsGiven > goalsTaken)
            {
                _totalPoints += 2;
            }
            else if (goalsGiven == goalsTaken)
            {
                _totalPoints += 1;
            }
            else
            {
                _totalPoints += 0;
            }
        }

        public int CalculateGoalPerformance(int scored, int taken)
        {
            return scored - taken;
        }

        public override string ToString()
        {
            return "Name: " + Name + " G scored: " + GScore + " G Conceded: " + GConceded + " No. of Matches: " + NuOfMatches + " Total points: " + TotalPoints;
        }

    }
}