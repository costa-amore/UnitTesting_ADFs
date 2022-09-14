using System;
using TME.OCA.BIQ.CLT.SourceDomain;
using TME.OCA.BIQ.CLT.SourceGateway;

namespace TME.OCA.BIQ.CLT.TestHelpers
{
    public class Given
    {
        internal static ReleaseToStore A(Release release)
        {
            return ReleaseToStore.CreateWith(release);
        }

        internal static ConfigurationToStore A(Configuration configuration)
        {
            return ConfigurationToStore.CreateWith(configuration);
        }

        internal static DeploymentToStore A(Deployment deployment)
        {
            return DeploymentToStore.CreateWith(deployment);
        }
    }
}