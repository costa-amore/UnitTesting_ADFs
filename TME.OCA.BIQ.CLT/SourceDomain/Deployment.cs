using System;

namespace TME.OCA.BIQ.CLT.SourceDomain
{
    internal class Deployment
    {
        #region construction
        internal static DeploymentBuilder Create()
        {
            return new DeploymentBuilder();
        }
        internal static Deployment Create(Release release, DeploymentEnvironment environment, DateTime deploymentTimeStamp)
        {
            return new Deployment(release, environment, deploymentTimeStamp);
        }
        internal static Deployment CreateEmpty()
        {
            return new Deployment(Release.CreateEmpty(), DeploymentEnvironment.CreateEmpty(), DateTime.MinValue);
        }
        private Deployment(Release release, DeploymentEnvironment deploymentEnvironment, DateTime deploymentTimeStamp)
        {
            Release = release;
            DeploymentEnvironment = deploymentEnvironment;
            DeploymentTimeStamp = deploymentTimeStamp;
        }
        #endregion

        public Release Release { get; }
        public DeploymentEnvironment DeploymentEnvironment { get; }
        public DateTime DeploymentTimeStamp { get; }
    }
}