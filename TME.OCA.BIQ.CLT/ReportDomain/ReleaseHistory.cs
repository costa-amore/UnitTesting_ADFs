using NUnit.Framework;
using System;
using System.Collections.Generic;
using TME.OCA.BIQ.CLT.ReportDataGateway;
using TME.OCA.BIQ.CLT.SourceDomain;

namespace TME.OCA.BIQ.CLT.ReportDomain
{
    internal class ReleaseHistory
    {

        #region construction
        internal static ReleaseHistory LoadOnce()
        {
            return new ReleaseHistory(ReportDatabaseHelper.LoadReleaseHistory());
        }
        private List<HistoricRelease> _releases;

        private ReleaseHistory(List<HistoricRelease> releases)
        {
            _releases = releases;
        }
        #endregion

        internal bool Contains(Release release)
        {
            throw new NotImplementedException();
        }
    }
}