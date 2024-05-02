namespace QEvents
{
    public class Events
    {
        static int _id;
        private string _name;
        private string _eType;
        private decimal _tPrice;
        private int _capacity;
        private int _sSold;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string EType
        {
            get { return _eType; }
            set { _eType = value; }
        }
        public decimal TPrice
        {
            get { return _tPrice; }
            set { _tPrice = value; }
        }
        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        public int SSold
        {
            get { return _sSold; }
            set { _sSold = value; }
        }


        public Events(string n, string eT, decimal tP, int c)
        {
            Name = n;
            EType = eT;
            TPrice = tP;
            Capacity = c;
            _id++;
        }

        public Events(string n, string eT, decimal tP, int c, int sS)
        {
            Name = n;
            EType = eT;
            TPrice = tP;
            Capacity = c;
            _sSold = sS;
            _id++;
        }

        public string GetPriceClassification()
        {
            if (TPrice < 50)
            {
                return "Low";
            }
            else if (TPrice >= 50 && TPrice <= 99)
            {
                return "Medium";
            }
            else
            {
                return "High";
            }
        }

        public double GetPercentageSeatsSold()
        {
            try
            {
                if ((Capacity == 0) || (SSold == 0))
                {
                    return 0;
                }
                else
                {
                    return (double)SSold / Capacity;
                }       
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            return 0;
        }

        public bool BuySeats(int NoTickets)
        {
            if ((NoTickets + SSold) >= Capacity)
            {
                return false;
            }
            else
            {
                SSold += NoTickets;
                return true;
            }
        }

        public override string ToString()
        {
            return "Name: " + Name + " Type: " + EType + " Ticket Price: " + TPrice + " Capacity: " + Capacity + " Seats sold: " + SSold + $" Seats % sold: {GetPercentageSeatsSold():p}";
        }

    }
}