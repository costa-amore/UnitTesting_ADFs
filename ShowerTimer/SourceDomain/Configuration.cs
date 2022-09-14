using System.Collections.Generic;

namespace TME.OCA.BIQ.CLT.SourceDomain
{
    internal class Configuration
    {
        #region construction
        internal static ConfigurationBuilder Create()
        {
            return new ConfigurationBuilder();
        }

        internal static Configuration Create(List<DeploymentEnvironment> environments, List<Application> applications, List<Component> components)
        {
            return new Configuration(environments, applications, components);
        }

        private Configuration(List<DeploymentEnvironment> environments, List<Application> applications, List<Component> components)
        {
            Environments = environments;
            Applications = applications;
            Components = components;
        }
        #endregion

        public List<DeploymentEnvironment> Environments { get; }
        public List<Application> Applications { get; }
        public List<Component> Components { get; }

    }
}