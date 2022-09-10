using System;

namespace Gedaq.Provider.Attributes.Constraints
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public abstract class ConstrainAttribute : Attribute
    {
        public ConstrainAttribute(string constrainName)
        {
        }
    }
}