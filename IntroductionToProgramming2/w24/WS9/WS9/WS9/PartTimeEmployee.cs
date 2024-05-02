using QEmployee;

namespace QPartTimeEmployee
{
    class PartTimeEmployee : Employee
    {
        private int _hoursWorked;

        public int HoursWorked
        {
            get { return _hoursWorked; }
            set { _hoursWorked = value; }
        }

        public PartTimeEmployee() : base()
        {

        }

        public PartTimeEmployee(string n, string gender, double hourlyRate, int hrs) : base(n, gender, hourlyRate)
        {
            HoursWorked = hrs;
        }

        public override double CalcPay()
        {
            return HoursWorked * HourlyRate;
        }

        public override string ToString()
        {
            return base.ToString() + " Hours Worked: " + HoursWorked;
        }
    }
}