namespace examMock
{
    class CommercialProperty : Property
    {
        private char _ratesBand;

        public char RatesBand 
        {
            get {return _ratesBand;}
            set 
            {
                if (value == 'A' || value == 'B' || value == 'C') 
                {
                    _ratesBand = value;
                }
                else 
                {
                    _ratesBand = 'E';
                }
            }
        }

        public CommercialProperty()
        {

        }

        public CommercialProperty(string eirCode, double rent, int beds, char ratesBand) : base(eirCode, ratesBand, beds)
        {      
            this._ratesBand = ratesBand;
        }

        public override bool EligibleForGrant()
        {
            char ratesBand = this._ratesBand;
            
            if (ratesBand == 'A') 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Rates band: "+_ratesBand;
        }
    }
}