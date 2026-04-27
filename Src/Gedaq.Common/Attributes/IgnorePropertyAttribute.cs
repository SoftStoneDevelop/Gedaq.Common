using System;

namespace Gedaq.Common.Attributes
{
    /// <summary>
    /// Specifies that this property is not included in the database mapping and will be ignored in generators.
    /// </summary>
    /// <seealso href="https://github.com/SoftStoneDevelop/Gedaq.DbConnection/blob/main/Documentation/IgnoreProperty.md"/>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class IgnorePropertyAttribute : Attribute
    {
    }
}