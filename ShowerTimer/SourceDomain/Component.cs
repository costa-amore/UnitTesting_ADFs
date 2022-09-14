using System;

namespace TME.OCA.BIQ.CLT.SourceDomain
{
    public class Component
    {
        #region construction
        internal static Component CreateEmpty()
        {
            return new Component("");
        }

        internal static Component Create(string componentName)
        {
            return new Component(componentName);
        }

        private Component(string componentName)
        {
            ComponentName = componentName;
        }
        #endregion

        public string ComponentName { get; }

    }
}