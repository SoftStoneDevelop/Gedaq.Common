using System;

namespace Gedaq.Provider.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class ColumnAttribute : Attribute
    {
        public ColumnAttribute(string nameInDatabase)
        {
        }
    }
}