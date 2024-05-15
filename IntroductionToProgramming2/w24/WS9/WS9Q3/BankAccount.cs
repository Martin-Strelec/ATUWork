namespace WS9Q3
{
    class BankAccount
    {
        private decimal _balance;

        public decimal Balance
        {
            get { return _balance; }
            set {_balance = value;}
        }

        public BankAccount()
        {
            _balance = 0;
        }
        public decimal Lodge(decimal amount)
        {
            _balance += amount;
            return _balance;
        }

        public virtual decimal WhitdrawFunds(decimal amount)
        {
            if ((_balance - amount) < 0)
            {
                Console.WriteLine("Insufficient funds!");
            }
            else
            {
                _balance -= amount;
                return _balance;
            }
            return 0;
        }

        public override string ToString()
        {
            return "Balance: " + _balance;
        }
    }
}