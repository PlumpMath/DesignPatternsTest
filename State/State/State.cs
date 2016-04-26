using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.State
{
    public class State
    {
        private BulbState BulbState = BulbState.Off;
        public void GetStatus()
        {
            Console.WriteLine($"Current state is {BulbState.ToString()}");
        }

        public void PressSwitch()
        {
            BulbState = BulbState == BulbState.On ? BulbState.Off : BulbState.On;
        }
    }
}
