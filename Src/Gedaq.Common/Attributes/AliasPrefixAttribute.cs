using System;

namespace Gedaq.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class AliasPrefixAttribute : Attribute
    {
        /// <param name="prefix">prefix for the all aliases contained in class</param>
        /// <remarks>Prefix and aliases used only if you choose to generate dynamic query. Prefix can be empty string only if query return single type.</remarks>
        public AliasPrefixAttribute(string prefix = "")
        {
        }
    }
}
