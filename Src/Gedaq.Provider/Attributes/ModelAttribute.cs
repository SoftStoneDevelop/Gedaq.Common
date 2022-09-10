using System;

namespace Gedaq.Provider.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false)]
    public sealed class TableAttribute : Attribute
    {
        public TableAttribute(string nameInDatabase)
        {
        }
    }
}