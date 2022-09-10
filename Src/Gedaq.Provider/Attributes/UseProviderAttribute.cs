using System;

namespace Gedaq.Provider.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false)]
    public sealed class UseProviderAttribute : Attribute
    {
    }
}