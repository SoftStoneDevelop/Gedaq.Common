using System;

namespace Gedaq.Common.Attributes
{
    /// <summary>
    /// An attribute for specifying the alias to be used in the SQL query or the order of the property in the query. Ordinal access takes precedence over named access if specified, as it provides faster access.
    /// </summary>
    /// <seealso href="https://github.com/SoftStoneDevelop/Gedaq.DbConnection/blob/main/Documentation/Alias.md"/>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class AliasAttribute : Attribute
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="alias">Alias of column in sql. If the alias is an empty string, the name of the property on which it was placed will be used as the alias. Also remember about AliasPrefix attribute.</param>
        /// <param name="order">Specifies the order, starting from 0, that this property will appear in the data returned in each row from the database.</param>
        public AliasAttribute(
            string alias = "",
            int order = -1)
        {
        }
    }
}