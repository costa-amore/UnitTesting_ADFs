using NUnit.Framework;
using System;
using System.Collections.Generic;
using TME.OCA.BIQ.CLT.ReportDomain;
using TME.OCA.BIQ.CLT.SourceDomain;

namespace TME.OCA.BIQ.CLT.ReportDataGateway
{
    internal class ChangeLeadTimeReportOfMonth
    {
        #region construction
        private List<ReportedChange> _changes;

        public ChangeLeadTimeReportOfMonth(List<ReportedChange> changes)
        {
            _changes = changes;
        }

        internal static ChangeLeadTimeReportOfMonth CreateFor(DateTime timeToExtractMonthFrom)
        {
            return new ChangeLeadTimeReportOfMonth(ReportDatabaseHelper.LoadChangesForMonth(timeToExtractMonthFrom));
        }
        #endregion

        internal bool Contains(Change change, int expectedChangeLeadTime)
        {
            throw new NotImplementedException();
        }

        internal bool DoesNotContain(Change change)
        {
            throw new NotImplementedException();
        }
    }
}