using System;

namespace Gedaq.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class AliasAttribute : Attribute
    {       
        /// <param name="alias">Alias of column in sql</param>
        /// <remarks>If the alias is an empty string, the name of the property on which it was placed will be used as the alias. Also remember about AliasPrefix attribute..</remarks>
        public AliasAttribute(string alias = "")
        {
        }
    }
}
