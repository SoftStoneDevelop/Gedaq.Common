using System;

namespace Gedaq.Provider.Enums
{
    [Flags]
    public enum MethodType
    {
        Sync = 1,
        Async = 2
    }
}