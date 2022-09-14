using NUnit.Framework;
using TME.OCA.BIQ.CLT.ReportDataGateway;
using TME.OCA.BIQ.CLT.ReportDomain;
using TME.OCA.BIQ.CLT.SourceDomain;
using TME.OCA.BIQ.CLT.TestHelpers;

namespace TME.OCA.BIQ.CLT
{
    public partial class Change_and_release_data_from_bamboo : DataFactoryTests
    {
        private Deployment _deploymentToDev = Deployment.CreateEmpty();

        public void Given_NO_production_deployment()
        {
            var developmentEnvironment = DeploymentEnvironment.Create("APP.DEV", DeploymentType.Dev);

            _deploymentToDev = Deployment.Create()
                    .With(_release)
                    .DeployedTo(developmentEnvironment)
                    .At(_time.Yesterday)
                    .Build();

            Given
                .A(Configuration.Create()
                    .With(developmentEnvironment)
                    .Build()
                ).StoredInTestSource();

            Given
                .A(_deploymentToDev)
                .StoredInTestSource();
        }

        [Test]
        public void Given_NO_production_deployment_THEN_changes_are_added_to_the_history()
        {
            Assert.That(ChangesHistory.LoadOnce().Contains(_change1));
            Assert.That(ChangesHistory.LoadOnce().Contains(_change2));
            Assert.That(ChangesHistory.LoadOnce().Contains(_change3));
        }

        [Test]
        public void Given_NO_production_deployment_THEN_release_is_added_to_the_history()
        {
            Assert.That(ReleaseHistory.LoadOnce().Contains(_release));
        }

        [Test]
        public void Given_NO_production_deployment_THEN_month_of_yesterday_does_NOT_contain_the_changes()
        {
            Assert.That(ChangeLeadTimeReport.OfMonth(_deploymentToDev.DeploymentTimeStamp).DoesNotContain(_change1));
            Assert.That(ChangeLeadTimeReport.OfMonth(_deploymentToDev.DeploymentTimeStamp).DoesNotContain(_change2));
            Assert.That(ChangeLeadTimeReport.OfMonth(_deploymentToDev.DeploymentTimeStamp).DoesNotContain(_change3));
        }
    }
}