using NUnit.Framework;
using System;
using TME.OCA.BIQ.CLT.SourceDomain;

namespace TME.OCA.BIQ.CLT.SourceGateway
{
    internal class ConfigurationToStore
    {
        #region construction
        public static ConfigurationToStore CreateWith(Configuration configuration)
        {
            return new ConfigurationToStore(configuration);
        }

        private Configuration _configuration;

        private ConfigurationToStore(Configuration configuration)
        {
            _configuration = configuration;
        }
        #endregion

        internal void StoredInTestSource()
        {
            SourceSystemHelper.AddConfigurationToSource(_configuration);
        }

    }
}