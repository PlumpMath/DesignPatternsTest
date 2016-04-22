namespace Builder.Report
{
    public abstract class ReportBuilder
    {
        protected Report Report;
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportFooter();

        public void CreateNewReport()
        {
            Report = new Report();
        }

        public Report GetReport()
        {
            return Report;
        }
    }
}
