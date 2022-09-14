using NUnit.Framework;
using System;
using TME.OCA.BIQ.CLT.SourceDomain;
using TME.OCA.BIQ.CLT.TestHelpers;

namespace TME.OCA.BIQ.CLT
{
    [TestFixture()]
    public class DataFactoryTests
    {
        protected MockedTime _time = MockedTime.CreateFrom(DateTime.MinValue);
        protected Component _component = Component.CreateEmpty();
        protected Application _application = Application.CreateEmpty();

        public DataFactoryTests()
        {
        }

        [OneTimeSetUp]
        public void RunPipeline()
        {
            Arrange();
            Act();
        }

        private void Act()
        {
            Assert.Warn("long running trigger");
        }

        public virtual void Arrange()
        {}
    }
}