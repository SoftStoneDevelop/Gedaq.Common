using Gedaq.Provider.Enums;
using System;

namespace Gedaq.Provider.Attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    public abstract class NonQueryAttribute : Attribute
    {
        protected NonQueryAttribute() { }

        public NonQueryAttribute(string[] queries, MethodType methodType)
        {
        }
    }
}