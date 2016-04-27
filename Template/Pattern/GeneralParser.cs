using System;

namespace Template.Pattern
{
    public abstract class GeneralParser
    {
        protected abstract void Load();
        protected abstract void Parse();

        protected virtual void Dump()
        {
            Console.WriteLine("Dump data in to oracle");
        }

        public void Process()
        {
            Load();
            Parse();
            Dump();
        }
    }
}
