using Builder.Report;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Report.Report report;
            ReportDirector director = new ReportDirector();

            ReportPdf pdf = new ReportPdf();
            report = director.MakeReport(pdf);
            report.DisplayReport();

            ReportExcel excel = new ReportExcel();
            report = director.MakeReport(excel);
            report.DisplayReport();
        }
    }
}
