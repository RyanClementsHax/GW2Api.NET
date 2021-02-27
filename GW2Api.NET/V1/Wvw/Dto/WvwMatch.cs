using System;

namespace GW2Api.NET.V1.Wvw.Dto
{
    public record WvwMatch(
        string WvwMatchId,
        int RedWorldId,
        int BlueWorldId,
        int GreenWorldId,
        DateTimeOffset StartTime,
        DateTimeOffset EndTime
    );
}
