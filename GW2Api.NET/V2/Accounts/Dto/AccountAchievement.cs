using System.Collections.Generic;

namespace GW2Api.NET.V2.Accounts.Dto
{
    public record AccountAchievement(
        int Id,
        IList<int> Bits,
        int? Current,
        int? Max,
        int? Repeated,
        bool? Unlocked
    );
}
