using Gedaq.Provider.Enums;
using System;

namespace Gedaq.Provider.Attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    public abstract class QueryReadAttribute : Attribute
    {
        protected QueryReadAttribute() { }

        public QueryReadAttribute(string[] queries, MethodType methodType)
        {
        }
    }
}