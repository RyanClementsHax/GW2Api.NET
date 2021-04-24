namespace GW2Api.NET.V2.Currencies.Dto
{
    public record Currency(
        int Id,
        string Name,
        string Description,
        string Icon,
        int Order
    );
}
