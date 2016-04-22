namespace Builder.Report
{
    public class ReportDirector
    {
        public Report MakeReport(ReportBuilder builder)
        {
            builder.CreateNewReport();
            builder.SetReportType();
            builder.SetReportHeader();
            builder.SetReportFooter();
            return builder.GetReport();
        }
    }
}
