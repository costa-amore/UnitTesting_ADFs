using TME.OCA.BIQ.CLT.SourceDomain;

namespace TME.OCA.BIQ.CLT.SourceGateway
{
    internal class ReleaseToStore
    {
        #region construction
        internal static ReleaseToStore CreateWith(Release release)
        {
            return new ReleaseToStore(release);
        }

        private Release _release;

        private ReleaseToStore(Release release)
        {
            _release = release;
        }
        #endregion

        internal void StoredInTestSource()
        {
            _release.Changes.ForEach((change) => SourceSystemHelper.AddChangeToSource(change, _release));
            SourceSystemHelper.AddReleaseToSource(_release);
        }

    }
}