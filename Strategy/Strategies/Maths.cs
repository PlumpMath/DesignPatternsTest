using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    public class Maths
    {
        public int Number1 = 0;
        public int Number2 = 0;
        private Strategy Strategy;

        public void SetStrategy(Strategy str)
        {
            Strategy = str;
        }

        public int Calculate()
        {
            return Strategy.Calculate(Number1, Number2);
        }
    }
}
