using NUnit.Framework;
using TME.OCA.BIQ.CLT.SourceDomain;

namespace TME.OCA.BIQ.CLT.SourceGateway
{
    internal class SourceSystemHelper
    {
        internal static void AddChangeToSource(Change change, Release release)
        {
            TestContext.Progress.WriteLine("storing change data");        
        }

        internal static void AddConfigurationToSource(Configuration configuration)
        {
            TestContext.Progress.WriteLine("storing configuration data");
        }

        internal static void AddDeploymentToSource(Deployment deployment)
        {
            TestContext.Progress.WriteLine("storing deployment data");
        }

        internal static void AddReleaseToSource(Release release)
        {
            TestContext.Progress.WriteLine("storing release data");
        }
    }
}