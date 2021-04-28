using System;

namespace GW2Api.NET.V2.Currencies.Dto
{
    public record Currency(
        int Id,
        string Name,
        string Description,
        Uri Icon,
        int Order
    );
}
