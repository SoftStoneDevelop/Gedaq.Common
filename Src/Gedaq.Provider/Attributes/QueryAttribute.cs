using Gedaq.Provider.Enums;
using System;

namespace Gedaq.Provider.Attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    public abstract class QueryReadAttribute : Attribute
    {
        protected QueryReadAttribute() { }

        public QueryReadAttribute(SelectItemType[] queries, MethodType methodType)
        {
        }
    }

    public class SelectItemType
    {
        public SelectItemType(string query, string itemTypeName) 
        {
        }
    }
}