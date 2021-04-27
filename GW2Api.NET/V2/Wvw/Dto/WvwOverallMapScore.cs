using System.Collections.Generic;

namespace GW2Api.NET.V2.Wvw.Dto
{
    public record WvwOverallMapScore(
        int Id,
        WvwMapType Type,
        IDictionary<ServerColor, int> Scores
    );
}
