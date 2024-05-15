using System.Dynamic;

namespace WS9Q3
{
    class CurrentAccount : BankAccount
    {
        private decimal _overdraft;
        public CurrentAccount(decimal overdraftLimit)
        {
            _overdraft = overdraftLimit;
        }

        public override decimal WhitdrawFunds(decimal amount)
        {
            if ((Balance - amount) < -_overdraft)
            {
                Console.WriteLine("Insufficient funds!");
                AddInterest(0.1);
            }
            else
            {
                Balance -= amount;
                return Balance;
            }

            return 0;
        }

        public void AddInterest(double interestRate)
        {
            
        }
    }
}
