using System.Collections.Generic;

namespace GW2Api.NET.V2.Wvw.Dto
{
    public record WvwMapStats(
        int Id,
        IDictionary<ServerColor, int> Deaths,
        IDictionary<ServerColor, int> Kills
    );
}