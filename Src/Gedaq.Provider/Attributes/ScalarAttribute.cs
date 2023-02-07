using Gedaq.Provider.Enums;
using System;

namespace Gedaq.Provider.Attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false)]
    public abstract class ScalarAttribute : Attribute
    {
        protected ScalarAttribute() { }

        public ScalarAttribute(
            string query,
            MethodType methodType
            )
        {
        }
    }
}