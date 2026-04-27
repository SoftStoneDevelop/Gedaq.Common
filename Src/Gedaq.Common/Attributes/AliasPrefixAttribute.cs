using System;

namespace Gedaq.Common.Attributes
{
    /// <summary>
    /// An attribute that specifies the prefix that will be used for all alias properties in this class when reading data from a database row.
    /// </summary>
    /// <seealso href="https://github.com/SoftStoneDevelop/Gedaq.DbConnection/blob/main/Documentation/AliasPrefix.md"/>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class AliasPrefixAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prefix">prefix for the all aliases contained in class. Prefix and aliases used only if you choose to generate dynamic query. Prefix can be empty string only if query return single type.</param>
        public AliasPrefixAttribute(string prefix = "")
        {
        }
    }
}
