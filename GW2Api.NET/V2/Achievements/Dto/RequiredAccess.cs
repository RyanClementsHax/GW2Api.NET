namespace GW2Api.NET.V2.Achievements.Dto
{
    public record RequiredAccess(
        Product Product,
        AccessCondition Condition
    );
}
