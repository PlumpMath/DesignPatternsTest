namespace COR.Pattern
{
    public abstract class Process
    {
        protected Process NextProces;

        public void SetProcess(Process proc)
        {
            NextProces = proc;
        }

        public abstract void RunProcess();
    }
}
