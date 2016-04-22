using System;
using System.Collections.Generic;

namespace Builder.Report
{
    public class Report
    {
        public string ReportType;
        private List<string> Headers = new List<string>();
        private List<string> Footers = new List<string>();

        public void SetReportHeader(string text)
        {
            Headers.Add(text);
        }

        public void SetReportFooter(string text)
        {
            Footers.Add(text);
        }

        public void DisplayReport()
        {
            foreach (string item in Headers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------");
            Console.WriteLine("--------------");
            Console.WriteLine("--------------");

            foreach (string item in Footers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
