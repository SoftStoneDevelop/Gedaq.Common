using System;

namespace Gedaq.Provider.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class PKAttribute : Attribute
    {
    }
}