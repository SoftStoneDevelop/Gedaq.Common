using System;

namespace Gedaq.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method, AllowMultiple = true)]
    public sealed class QueryFormatAttribute : Attribute
    {
        public QueryFormatAttribute(
            int position,
            string parametrName = null)
        {
        }
    }
}