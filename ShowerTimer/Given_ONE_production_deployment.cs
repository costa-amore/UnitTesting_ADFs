using NUnit.Framework;
using TME.OCA.BIQ.CLT.ReportDataGateway;
using TME.OCA.BIQ.CLT.SourceDomain;
using TME.OCA.BIQ.CLT.TestHelpers;

namespace TME.OCA.BIQ.CLT
{
    public partial class Change_and_release_data_from_bamboo : DataFactoryTests
    {
        private Deployment _deploymentToProd = Deployment.CreateEmpty();

        public void Given_ONE_production_deployment()
        {
            var productionEnvironment = DeploymentEnvironment.Create("APP.PRD", DeploymentType.Prod);

            _deploymentToProd = Deployment.Create()
                    .With(_releaseForProd)    
                    .DeployedTo(productionEnvironment)
                    .At(_time.Yesterday)
                    .Build();

            Given
                .A(Configuration.Create()
                    .With(productionEnvironment)
                    .Build()
                ).StoredInTestSource();

            Given
                .A(_deploymentToProd)
                .StoredInTestSource();
        }

        [Test]
        public void Given_ONE_production_deployment_THEN_month_of_yesterday_contains_the_changes()
        {
            Assert.That(ChangeLeadTimeReport.OfMonth(_deploymentToProd.DeploymentTimeStamp).Contains(_change4, 9));
            Assert.That(ChangeLeadTimeReport.OfMonth(_deploymentToProd.DeploymentTimeStamp).Contains(_change5, 8));
            Assert.That(ChangeLeadTimeReport.OfMonth(_deploymentToProd.DeploymentTimeStamp).Contains(_change6, 7));
        }
    }
}