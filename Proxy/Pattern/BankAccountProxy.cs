using System;

namespace Proxy.Pattern
{
    public class BankAccountProxy : IBankAccount
    {
        private readonly bool userIsAuthorized;

        private BankAccount realAccount;

        public BankAccountProxy(string userName, string secretKey)
        {
            if (userName != null && secretKey != null)
            {
                userIsAuthorized = true;
            }
        }

        public bool Deposit(decimal amount)
        {
            if (amount < 25)
            {
                Console.WriteLine("Minimum deposit amount is 25!");
                return false;
            }

            if (amount > 1000)
            {
                Console.WriteLine("Maximum deposit amount is 1000!");
                return false;
            }

            if (!userIsAuthorized)
            {
                Console.WriteLine("You are not authorized!");
                Console.WriteLine("Redirecting you to login screen...");
                return false;
            }

            CheckIfAccountIsActive();

            realAccount.Deposit(amount);

            return true;
        }

        public bool Withdraw(decimal amount)
        {
            CheckIfAccountIsActive();
            if (amount <= CurrentBallance())
            {
                realAccount.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Не може да изтеглите повече, отколкото притежавате");
            }
            return true;
        }

        public decimal CurrentBallance()
        {
            CheckIfAccountIsActive();

            return realAccount.CurrentBallance();
        }

        private void CheckIfAccountIsActive()
        {
            if (realAccount == null)
            {
                realAccount = new BankAccount();
            }
        }
    }
}
