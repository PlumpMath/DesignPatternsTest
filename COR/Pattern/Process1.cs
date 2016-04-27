using System;

namespace COR.Pattern
{
    public class Process1 : Process
    {
        public override void RunProcess()
        {
            Console.WriteLine("Process 1");
            if (NextProces != null)
            {
                NextProces.RunProcess();
            }
        }
    }
}
