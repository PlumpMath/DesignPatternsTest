using Proxy.Pattern;
using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccountProxy acc = new BankAccountProxy("Моя милост", "тайна");
            Console.WriteLine($"Наличността е {acc.CurrentBallance().ToString("C2")}");
            acc.Deposit(20);
            Console.WriteLine($"Наличността е {acc.CurrentBallance().ToString("C2")}");
            acc.Deposit(900);
            Console.WriteLine($"Наличността е {acc.CurrentBallance().ToString("C2")}");
            acc.Deposit(10000);
            Console.WriteLine($"Наличността е {acc.CurrentBallance().ToString("C2")}");

            acc.Withdraw(100);
            Console.WriteLine($"Наличността е {acc.CurrentBallance().ToString("C2")}");
            acc.Withdraw(10000);
            Console.WriteLine($"Наличността е {acc.CurrentBallance().ToString("C2")}");
        }
    }
}
