namespace examMock
{
    class Property
    {
        private int _propertyNumber;
        private string _eircode;
        private double _propertyRent;
        private int _numberOfBeds;
        private static int _numberOfProperties = 0;

        //Public getters and setters
        public int PropertyNumber
        {
            get { return _propertyNumber; }
        }

        public string EirCode
        {
            get { return _eircode; }
            set
            {
                if (value[0] == 'D' && value.Length == 6)
                {
                    _eircode = value;
                }
                else
                {
                    _eircode = "#EEEEE";
                }
            }
        }

        public double PropertyRent
        {
            get { return _propertyRent; }
            set { _propertyRent = value; }
        }

        public int NumberOfBeds
        {
            get { return _numberOfBeds; }
            set { _numberOfBeds = value; }
        }

        //Parametrised constructor
        public Property(string eirCode, double propertyRent, int numberOfBeds)
        {
            EirCode = eirCode;
            this._propertyRent = propertyRent;
            this._numberOfBeds = numberOfBeds;
            this._propertyNumber = _numberOfProperties;
            _numberOfProperties++;
        }

        //Default constructor
        public Property()
        {
            this._propertyNumber = _numberOfProperties;
            _numberOfProperties++;
        }

        public virtual bool EligibleForGrant()
        {
            double rent = _propertyRent;
            if (rent <= 1000 && rent > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetPricePerBedSpaces(double rent, int beds) 
        {
            return (double)rent/beds;
        }

        public override string ToString()
        {
            return "Property Number: " +_propertyNumber +" Eircode: " +_eircode+" Eligible for Grant: " +EligibleForGrant()+" Bed spaces: " +_numberOfBeds+" Price per Bed: " +GetPricePerBedSpaces(_propertyRent, _numberOfBeds);
        }
    }
}