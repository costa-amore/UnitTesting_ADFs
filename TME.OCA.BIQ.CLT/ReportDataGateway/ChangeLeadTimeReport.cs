using System;

namespace TME.OCA.BIQ.CLT.ReportDataGateway
{
    internal class ChangeLeadTimeReport
    {
        internal static ChangeLeadTimeReportOfMonth OfMonth(DateTime timeToExtractMonthFrom)
        {
            return ChangeLeadTimeReportOfMonth.CreateFor(timeToExtractMonthFrom);
        }
    }
}