using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TME.OCA.BIQ.CLT.SourceDomain
{
    public class Application
    {
        #region construction
        internal static Application CreateEmpty()
        {
            return new Application("", new List<Component>());
        }
        internal static Application Create(string name, List<Component> components)
        {
            return new Application(name, components);
        }
        internal static ApplicationBuilder Create()
        {
            return new ApplicationBuilder();
        }

        private Application(string name, List<Component> components)
        {
            Name = name;
            Components = components;
        }
        #endregion

        public string Name { get; }
        public List<Component> Components { get; }
    }
}