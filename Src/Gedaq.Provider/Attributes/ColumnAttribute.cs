using System;

namespace Gedaq.Provider.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public abstract class ColumnAttribute : Attribute
    {
        protected ColumnAttribute(string nameInDatabase, bool notNull)
        {
        }
    }
}