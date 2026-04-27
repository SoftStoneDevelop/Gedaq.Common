using System;

namespace Gedaq.Common.Attributes
{
    /// <summary>
    /// An attribute indicating the presence of dummy parts in the request
    /// </summary>
    /// <seealso href="https://github.com/SoftStoneDevelop/Gedaq.DbConnection/blob/main/Documentation/QueryFormat.md"/>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method, AllowMultiple = true)]
    public sealed class QueryFormatAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="position">Position in string.Format</param>
        /// <param name="parametrName">The name of the parameter in the generated method</param>
        public QueryFormatAttribute(
            int position,
            string? parametrName = null)
        {
        }
    }
}