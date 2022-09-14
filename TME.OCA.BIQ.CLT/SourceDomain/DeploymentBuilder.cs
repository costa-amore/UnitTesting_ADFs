using System;

namespace TME.OCA.BIQ.CLT.SourceDomain
{
    internal class DeploymentBuilder
    {
        private Release _release = Release.CreateEmpty();
        private DeploymentEnvironment _environment = DeploymentEnvironment.CreateEmpty();
        private DateTime _deploymentTimeStamp = DateTime.MinValue;

        internal DeploymentBuilder At(DateTime deploymentTimeStamp)
        {
            _deploymentTimeStamp = deploymentTimeStamp;
            return this;
        }

        internal Deployment Build()
        {
            return Deployment.Create(_release, _environment, _deploymentTimeStamp);
        }

        internal DeploymentBuilder DeployedTo(DeploymentEnvironment environment)
        {
            _environment = environment;
            return this;
        }

        internal DeploymentBuilder With(Release release)
        {
            _release = release;
            return this;
        }
    }
}