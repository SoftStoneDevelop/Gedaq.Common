﻿using Gedaq.Provider.Enums;
using System;

namespace Gedaq.Provider.Attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false)]
    public abstract class QueryReadAttribute : Attribute
    {
        protected QueryReadAttribute() { }

        public QueryReadAttribute((string query, string itemTypeName)[] queries, MethodType methodType)
        {
        }
    }
}