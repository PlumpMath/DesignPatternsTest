namespace Proxy.Pattern
{
    public interface IBankAccount
    {
        bool Deposit(decimal amount);
        bool Withdraw(decimal amount);
        decimal CurrentBallance();
    }
}
