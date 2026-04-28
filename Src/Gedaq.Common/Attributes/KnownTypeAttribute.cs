using System;

namespace Gedaq.Common.Attributes
{
    /// <summary>
    /// Indicates that a property of this type is known to the provider
    /// </summary>
    /// <seealso href="https://github.com/SoftStoneDevelop/Gedaq.DbConnection/blob/main/Documentation/KnownType.md"/>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class KnownTypeAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public KnownTypeAttribute()
        {
        }
    }
}