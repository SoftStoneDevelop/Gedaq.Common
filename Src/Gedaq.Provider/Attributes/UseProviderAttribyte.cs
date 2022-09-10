using System;

namespace Gedaq.Provider.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
    public sealed class UseProviderAttribute : Attribute
    {
    }
}