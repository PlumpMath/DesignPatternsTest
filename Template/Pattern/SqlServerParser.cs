using System;

namespace Template.Pattern
{
    public class SqlServerParser : GeneralParser
    {
        protected override void Load()
        {
            Console.WriteLine("Connect to SQL Server");
        }
        protected override void Parse()
        {
            Console.WriteLine("Loop through the dataset");
        }

    }
}
