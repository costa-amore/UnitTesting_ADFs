using System;
using System.Collections.Generic;

namespace TME.OCA.BIQ.CLT.SourceDomain
{
    internal class ApplicationBuilder
    {
        private string _name = "";
        private List<Component> _components = new();

        internal Application Build()
        {
            return Application.Create(_name, _components);
        }

        internal ApplicationBuilder WithComponent(Component component)
        {
            _components.Add(component);
            return this;
        }

        internal ApplicationBuilder WithName(string applicationName )
        {
            _name = applicationName;
            return this ;
        }
    }
}