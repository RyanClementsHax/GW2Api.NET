using System.Collections.Generic;

namespace GW2Api.NET.V2.Commerce.Dto
{
    public record ListingInfo(
        int Id,
        IList<Listing> Buys,
        IList<Listing> Sells
    );
}
