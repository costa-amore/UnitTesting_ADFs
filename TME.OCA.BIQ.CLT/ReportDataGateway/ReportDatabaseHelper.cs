using NUnit.Framework;
using System;
using System.Collections.Generic;
using TME.OCA.BIQ.CLT.ReportDomain;

namespace TME.OCA.BIQ.CLT.ReportDataGateway
{
    internal class ReportDatabaseHelper
    {
        internal static List<ReportedChange> LoadChangesForMonth(DateTime timeToExtractMonthFrom)
        {
            Assert.Warn("loading reported Changes");
            return new List<ReportedChange>();
        }

        internal static List<HistoricChange> LoadChangesHistory()
        {
            Assert.Warn("loading historic Changes");
            return new List<HistoricChange>();
        }

        internal static List<HistoricRelease> LoadReleaseHistory()
        {
            Assert.Warn("loading historic releases");
            return new List<HistoricRelease>();
        }
    }
}