using System;

namespace GW2Api.NET.V2.Common
{
    public record Page<T>(
        T Data,
        int PageSize,
        int PageTotal,
        int ResultCount,
        int ResultTotal
    );
}
