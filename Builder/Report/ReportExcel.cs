namespace Builder.Report
{
    public class ReportExcel : ReportBuilder
    {
        public override void SetReportFooter()
        {
            Report.SetReportFooter("Аз съм Ексел долен");
        }

        public override void SetReportHeader()
        {
            Report.SetReportHeader("Аз съм Ексел горен");
        }

        public override void SetReportType()
        {
            Report.ReportType = "EXCEL";
        }
    }
}
