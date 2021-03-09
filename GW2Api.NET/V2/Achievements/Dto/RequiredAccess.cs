using GW2Api.NET.V2.Common;

namespace GW2Api.NET.V2.Achievements.Dto
{
    public record RequiredAccess(
        Content Product,
        AccessCondition Condition
    );
}
