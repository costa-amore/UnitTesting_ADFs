using System.Collections.Generic;

namespace TME.OCA.BIQ.CLT.SourceDomain
{
    internal class ConfigurationBuilder
    {
        private readonly List<DeploymentEnvironment> _environments = new();
        private readonly List<Application> _applications = new();
        private readonly List<Component> _components = new();

        internal Configuration Build()
        {
            return Configuration.Create(_environments, _applications, _components);
        }

        internal ConfigurationBuilder With(DeploymentEnvironment environment)
        {
            _environments.Add(environment);
            return this;
        }

        internal ConfigurationBuilder With(Application application)
        {
            _applications.Add(application);
            return this;
        }

        internal ConfigurationBuilder With(Component component)
        {
            _components.Add(component);
            return this;
        }
    }
}