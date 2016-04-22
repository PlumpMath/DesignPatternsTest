namespace Builder.Report
{
    public class ReportPdf : ReportBuilder
    {
        public override void SetReportFooter()
        {
            Report.SetReportFooter("Аз съм ПДФ долен");
        }

        public override void SetReportHeader()
        {
            Report.SetReportHeader("Аз съм ПДФ горен");
        }

        public override void SetReportType()
        {
            Report.ReportType = "PDF";
        }
    }
}
