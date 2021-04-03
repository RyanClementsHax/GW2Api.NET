using System;

namespace GW2Api.NET.V2.Commerce.Dto
{
    public record Transaction(
        long Id,
        int ItemId,
        decimal Price,
        int Quantity,
        DateTimeOffset Created,
        DateTimeOffset? Purchased
    );
}
