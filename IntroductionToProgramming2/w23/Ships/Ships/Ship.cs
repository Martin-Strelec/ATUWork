// Author: Martin Strelec 
// Purpose: Creates an vessel object
// Constructor: new Ship("string<name>", int<typeCode>, int<tonnage>, int<crewMembers>, int<locationCode>)
// Methods: GetCrewMontthlyCost > Running cost of a vessel
//        : VesselReport > Shows vessel Location, Function, Name, Tonnage, Crew and Monthly Cost of a vessel

using System.Reflection.Metadata.Ecma335;

namespace QShip
{
    class Ship
    {
        static readonly int[] costPCMember = { 2610, 2350, 2050, 999, 2550, 2510 };
        static readonly string[] vesselFunction = { "Aircraft carrier", "Cruiser/Battleship", "Destroyer", "Frigate", "Nuclear Submarine", "Minelayer/Sweeper" };
        static private string[] locations = { "Pacific", "Atlantic", "Mediterranean", "Indian Ocean", "Other Seas" };

        private string _name;
        private int _typeCode;
        private string _function;
        private string _location;
        private int _tonnage;
        private int _crew;
        private int _locationCode;
        static int shipCount;

        public string Name
        {
            get { return _name; }
        }
        public string[] Locations
        {
            get { return locations; }
        }
        public int TypeCode
        {
            get { return _typeCode; }
        }

        public string Function
        {
            get { return _function; }
            set { _function = vesselFunction[_typeCode - 1]; }
        }
        public string Location
        {
            get { return _location; }
            set { _location = locations[_locationCode - 1]; }
        }
        public int Tonnage
        {
            get { return _tonnage; }
        }

        public int Crew
        {
            get { return _crew; }
        }

        public int LocationCode
        {
            get { return _locationCode; }
        }

        public Ship(string n, int ty, int to, int c, int l)
        {
            _name = n;
            _typeCode = ty;
            _tonnage = to;
            _crew = c;
            _locationCode = l;
            Function = _function;
            Location = _location;
            shipCount++;
        }

        //Return monthly cost of an vessel
        public decimal GetCrewMonthlyCost(int code, int crew)
        {
            decimal result = costPCMember[code] * crew;

            return result;
        }

        // Creates a vessel report
        public void VesselReport(int locationCode)
        {
            const string TAB = "{0,-30}{1,-30}{2,-25}{3,-15}{4,-15}{5,-15}";
            if ((Tonnage >= 3500 || Function == "Nuclear Submarine")&& locationCode == LocationCode)
            {
                Console.WriteLine(TAB, $"{Location}", $"{Function}", $"{Name}", $"{Tonnage}T", $"{Crew} people", $"{GetCrewMonthlyCost(TypeCode, Crew):c}");
            }
        }

        public override string ToString()
        {
            return "Name: "+Name+" TypeCode: "+TypeCode+" Tonnage: "+Tonnage+" Crew: "+Crew+" LocationCode: "+LocationCode;
        }
    }
}