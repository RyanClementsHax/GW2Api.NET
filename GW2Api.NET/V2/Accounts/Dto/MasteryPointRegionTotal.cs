namespace GW2Api.NET.V2.Accounts.Dto
{
    public record MasteryPointRegionTotal(
        string Region,
        int Spent,
        int Earned
    );
}
