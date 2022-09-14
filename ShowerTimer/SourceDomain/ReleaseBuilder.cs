using System;
using System.Collections.Generic;

namespace TME.OCA.BIQ.CLT.SourceDomain
{
    internal class ReleaseBuilder
    {
        private DateTime _releaseTimeStamp = DateTime.MinValue;
        private DeploymentEnvironment _environment = DeploymentEnvironment.CreateEmpty();
        private List<Change> _changes = new();
        private string _releaseName = "";


        internal Release Build()
        {
            return Release.Create(_releaseName, _changes);
        }

        internal ReleaseBuilder WithChanges(List<Change> changes)
        {
            _changes = changes;
            return this;
        }

        internal ReleaseBuilder WithName(string releaseName)
        {
            _releaseName = releaseName;
            return this;
        }
    }
}