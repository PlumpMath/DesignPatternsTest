using Adapter.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollectionBase adapter = new CollectionAdapter();
            adapter.Add("dddd");
        }
    }
}
