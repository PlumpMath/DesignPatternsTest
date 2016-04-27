using System;
using Template.Pattern;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            FileParser fileParser = new FileParser();
            fileParser.Process();
            Console.WriteLine("-----------------------");
            SqlServerParser sqlParser = new SqlServerParser();
            sqlParser.Process();
        }
    }
}
