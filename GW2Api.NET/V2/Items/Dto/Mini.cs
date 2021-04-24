namespace GW2Api.NET.V2.Items.Dto
{
    public record Mini(
        int Id,
        string Name,
        string Unlock,
        string Icon,
        int Order,
        int ItemId
    );
}
