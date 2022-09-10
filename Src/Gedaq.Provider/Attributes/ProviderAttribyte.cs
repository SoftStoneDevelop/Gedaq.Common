using System;

namespace Gedaq.Provider.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public abstract class ProviderAttribute : Attribute
    {
    }
}