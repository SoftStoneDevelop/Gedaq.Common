using Gedaq.Provider.Enums;
using System;

namespace Gedaq.Provider.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class ProviderAttribute : Attribute
    {
        public ProviderAttribute(Dialect dialect)
        {
        }
    }
}