namespace GW2Api.NET.V2.Commerce.Dto
{
    public record MarketPrice(
        int Id,
        bool WhiteListed,
        Price Buys,
        Price Sells
    );
}
