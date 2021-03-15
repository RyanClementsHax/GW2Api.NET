namespace GW2Api.NET.V2.Accounts.Dto
{
    public record MaterialSummary(
        int Id,
        int Category,
        AccountBinding? Binding,
        int Count
    );
}
