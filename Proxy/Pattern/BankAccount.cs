namespace Proxy.Pattern
{
    public class BankAccount : IBankAccount
    {
        public BankAccount()
        {
            Balance = 5000;
        }

        private decimal Balance { get; set; }

        public bool Deposit(decimal amount)
        {
            Balance += amount;
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            Balance -= amount;
            return true;
        }

        public decimal CurrentBallance()
        {
            return Balance;
        }
    }
}
