using System;
using System.Collections.Generic;
using TME.OCA.BIQ.CLT.ReportDataGateway;
using TME.OCA.BIQ.CLT.SourceDomain;

namespace TME.OCA.BIQ.CLT.ReportDomain
{
    internal class ChangesHistory
    {
        #region construction
        internal static ChangesHistory LoadOnce()
        {
            return new ChangesHistory(ReportDatabaseHelper.LoadChangesHistory());
        }

        private List<HistoricChange> _historicChanges;

        private ChangesHistory(List<HistoricChange> historicChanges)
        {
            _historicChanges = historicChanges;
        }
        #endregion

        internal bool Contains(Change change)
        {
            throw new NotImplementedException();
        }
    }
}