using System.Collections.Generic;

namespace Singleton.Entities
{
    public class Country
    {
        List<string> Countries = new List<string>();
        public Country()
        {
            Countries.Add("Bulgaria");
            Countries.Add("Russia");
            Countries.Add("USA");
            Countries.Add("UK");

        }
        public IEnumerable<string> getCounties()
        {
            return Countries;
        }
    }
}
