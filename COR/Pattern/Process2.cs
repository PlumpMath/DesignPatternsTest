using System;

namespace COR.Pattern
{
    public class Process2 : Process
    {
        public override void RunProcess()
        {
            Console.WriteLine("Process 2");
            if (NextProces != null)
            {
                NextProces.RunProcess();
            }
        }
    }
}
