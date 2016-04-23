using System.Collections.Generic;

namespace Singleton.Entities
{
    public class Currency
    {
        List<string> Currencies = new List<string>();
        public Currency()
        {
            Currencies.Add("BGR");
            Currencies.Add("USD");
            Currencies.Add("NEP");
            Currencies.Add("GBP");

        }
        public IEnumerable<string> getCurrencies()
        {
            return Currencies;
        }
    }
}
