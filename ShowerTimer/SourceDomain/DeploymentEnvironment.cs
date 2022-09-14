using System;

namespace TME.OCA.BIQ.CLT.SourceDomain
{
    internal class DeploymentEnvironment
    {
        #region construction
        internal static DeploymentEnvironment Create(string environmentName, DeploymentType type)
        {
            return new DeploymentEnvironment(environmentName, type);
        }

        internal static DeploymentEnvironment CreateEmpty()
        {
            return new DeploymentEnvironment("", DeploymentType.None);
        }

        private DeploymentEnvironment(string environmentName, DeploymentType type)
        {
            EnvironmentName = environmentName;
            Type = type;
        }
        #endregion

        public string EnvironmentName { get; }
        public DeploymentType Type { get; }

    }

    enum DeploymentType
    {
        None, Dev, Acc, Prod
    }
}