using System;

namespace TME.OCA.BIQ.CLT.SourceDomain
{
    internal class Change
    {
        #region construction
        internal static Change CreateEmpty()
        {
            return new Change(-1, Application.CreateEmpty(), Component.CreateEmpty(), DateTime.MinValue);
        }
        internal static Change Create(int changeId, Application applicationChanged, Component componentChanged, DateTime gitCommitTimeStamp)
        {
            return new Change(changeId, applicationChanged, componentChanged, gitCommitTimeStamp);
        }

        private Change(int changeId, Application applicationChanged, Component componentChanged, DateTime gitCommitTimeStamp)
        {
            ChangeId = changeId;
            ApplicationChanged = applicationChanged;
            ComponentChanged = componentChanged;
            GitCommitTimeStamp = gitCommitTimeStamp;
        }
        #endregion

        public int ChangeId { get; }
        public Application ApplicationChanged { get; }
        public Component ComponentChanged { get; }
        public DateTime GitCommitTimeStamp { get; }
    }
}