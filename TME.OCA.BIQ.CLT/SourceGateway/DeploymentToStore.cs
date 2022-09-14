using TME.OCA.BIQ.CLT.SourceDomain;

namespace TME.OCA.BIQ.CLT.SourceGateway
{
    internal class DeploymentToStore
    {
        #region construction
        internal static DeploymentToStore CreateWith(Deployment deployment)
        {
            return new DeploymentToStore(deployment);
        }

        private Deployment _deployment;

        private DeploymentToStore(Deployment deployment)
        {
            _deployment = deployment;
        }
        #endregion

        internal void StoredInTestSource()
        {
            SourceSystemHelper.AddDeploymentToSource(_deployment);
        }
    }
}