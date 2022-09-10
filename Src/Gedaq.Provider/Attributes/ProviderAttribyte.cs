using Gedaq.Provider.Enums;
using System;

namespace Gedaq.Provider.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class ProviderAttribyte : Attribute
    {
        public ProviderAttribyte(Dialect dialect)
        {
        }
    }
}