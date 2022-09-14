using System;
using System.Collections.Generic;

namespace TME.OCA.BIQ.CLT.SourceDomain
{
    internal class Release
    {
        #region construction
        internal static ReleaseBuilder Create()
        {
            return new ReleaseBuilder();
        }

        internal static Release Create(string releaseName, List<Change> changes)
        {
            return new Release(releaseName, changes);
        }

        internal static Release CreateEmpty()
        {
            return new Release("", new List<Change>());
        }

        private Release(string releaseName, List<Change> changes)
        {
            ReleaseName = releaseName;
            Changes = changes;
        }
        #endregion

        public string ReleaseName { get; }
        public List<Change> Changes { get; }

    }
}