using System.Collections.Generic;

namespace GW2Api.NET.V2.Commerce.Dto
{
    public record ItemListing(
        int Id,
        IList<Listing> Buys,
        IList<Listing> Sells
    );
}
