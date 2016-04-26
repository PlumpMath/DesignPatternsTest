using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Pattern
{
    public class CollectionAdapter : MyCollection
    {
        private MyStack MyStack = new MyStack();

        public override void Add(string str)
        {
            MyStack.Push(str);
        }
    }
}
