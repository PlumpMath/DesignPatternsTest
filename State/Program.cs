using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            State.State state = new State.State();

            while (Console.ReadLine() != "exit")
            {
                state.PressSwitch();
                state.GetStatus();
            }
        }
    }
}
