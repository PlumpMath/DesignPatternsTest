using System;

namespace COR.Pattern
{
    public class Process3 : Process
    {
        public override void RunProcess()
        {
            Console.WriteLine("Process 3");
            if (NextProces != null)
            {
                NextProces.RunProcess();
            }
        }
    }
}
