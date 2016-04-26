using System.Collections.Generic;

namespace Adapter.Pattern
{
    public class MyCollection : ICollectionBase
    {
        public List<string> MyList = new List<string>();
        public virtual void Add(string str)
        {
            MyList.Add(str);
        }
    }
}
