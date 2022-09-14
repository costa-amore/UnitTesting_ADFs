using System;
using System.Collections.Generic;
using TME.OCA.BIQ.CLT.SourceDomain;
using TME.OCA.BIQ.CLT.TestHelpers;

namespace TME.OCA.BIQ.CLT
{
    public partial class Change_and_release_data_from_bamboo : DataFactoryTests
    {
        private Change _change1 = Change.CreateEmpty();
        private Change _change2 = Change.CreateEmpty();
        private Change _change3 = Change.CreateEmpty();
        private Change _change4 = Change.CreateEmpty();
        private Change _change5 = Change.CreateEmpty();
        private Change _change6 = Change.CreateEmpty();

        private Release _release = Release.CreateEmpty();
        private Release _releaseForProd = Release.CreateEmpty();

        public override void Arrange()
        {
            _time = MockedTime.CreateFrom(DateTime.Now);
            
            // default repository
            _component = Component.Create("component");
            _application = Application.Create()
                    .WithName("app")
                    .WithComponent(_component)
                    .Build();
            Given
                .A(Configuration.Create()
                    .With(_application)
                    .With(_component)
                    .Build()
                ).StoredInTestSource();

            // timeline of default repository
            _change1 = Change.Create(1, _application, _component, _time.DaysAgo(14));
            _change2 = Change.Create(2, _application, _component, _time.DaysAgo(12));
            _change3 = Change.Create(3, _application, _component, _time.DaysAgo(10));

            _release = Release.Create()
                    .WithName(_application.Name + "_1.2.3")
                    .WithChanges(new List<Change>() {
                            _change1,
                            _change2,
                            _change3
                    })
                    .Build();
            Given.A(_release).StoredInTestSource();

            _change4 = Change.Create(4, _application, _component, _time.DaysAgo(9));
            _change5 = Change.Create(5, _application, _component, _time.DaysAgo(8));
            _change6 = Change.Create(6, _application, _component, _time.DaysAgo(7));


            _releaseForProd = Release.Create()
                .WithName(_application.Name + "_1.2.6")
                .WithChanges(new List<Change>() {
                            _change4,
                            _change5,
                            _change6
                })
                .Build();
            Given.A(_releaseForProd).StoredInTestSource();

            Given_NO_production_deployment();
            Given_ONE_production_deployment();
        }
    }
}