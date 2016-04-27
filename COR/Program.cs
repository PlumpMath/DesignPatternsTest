using COR.Pattern;

namespace COR
{
    class Program
    {
        static void Main(string[] args)
        {
            Process1 proc1 = new Process1();
            Process2 proc2 = new Process2();
            Process3 proc3 = new Process3();

            proc1.SetProcess(proc2);
            proc2.SetProcess(proc3);

            proc1.RunProcess();
        }
    }
}
