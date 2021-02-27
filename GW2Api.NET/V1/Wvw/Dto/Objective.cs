namespace GW2Api.NET.V1.Wvw.Dto
{
    public record Objective(
        int Id,
        WvwOwner Owner,
        string OwnerGuild
    );
}
