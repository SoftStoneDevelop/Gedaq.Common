using System;

namespace Gedaq.Provider.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false)]
    public abstract class TableAttribute : Attribute
    {
        public TableAttribute(string nameInDatabase)
        {
        }
    }
}