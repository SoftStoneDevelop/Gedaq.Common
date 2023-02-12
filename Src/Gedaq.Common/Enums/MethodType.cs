using System;

namespace Gedaq.Provider.Enums
{
    [Flags]
    public enum MethodType
    {
        Sync = 0,
        Async = 2
    }
}