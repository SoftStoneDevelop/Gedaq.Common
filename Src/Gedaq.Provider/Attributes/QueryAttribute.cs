using Gedaq.Provider.Enums;
using System;

namespace Gedaq.Provider.Attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false)]
    public abstract class QueryAttribute : Attribute
    {
        protected QueryAttribute() { }

        protected QueryAttribute((string query, string itemTypeName, ResultType resultMethodType)[] queries, MethodType methodType)
        {
        }
    }
}