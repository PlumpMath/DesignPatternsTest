using Singleton.Entities;
using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalSingleton singleton = GlobalSingleton.Instance;

            foreach (string item in singleton.Currencies.getCurrencies())
            {
                Console.WriteLine(item);
            }

            foreach (string item in singleton.Countries.getCounties())
            {
                Console.WriteLine(item);
            }
        }
    }
}
