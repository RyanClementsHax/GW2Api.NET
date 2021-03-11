using System.Collections.Generic;

namespace GW2Api.NET.V2.Accounts.Dto
{
    public record AccountAchievement(
        int Id,
        IReadOnlyCollection<int> Bits,
        int? Current,
        int? Max,
        int? Repeated,
        bool? Unlocked
    );
}
