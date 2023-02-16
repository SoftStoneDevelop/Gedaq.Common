using System;

namespace Gedaq.Common.Enums
{
    [Flags]
    public enum QueryType
    {
        Read = 1,
        NonQuery = 2,
        Scalar = 4
    }
}