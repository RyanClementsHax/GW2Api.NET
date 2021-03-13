namespace GW2Api.NET.V2.Accounts.Dto
{
    public record AccountFinisher(
        int Id,
        bool Permanent,
        int? Quantity
    );
}
