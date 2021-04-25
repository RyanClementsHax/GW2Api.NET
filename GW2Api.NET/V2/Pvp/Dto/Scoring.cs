using System;

namespace GW2Api.NET.V2.Pvp.Dto
{
    public record Scoring(
        Guid Id,
        ScoringType Type,
        string Description,
        string Name,
        string Ordering
    );
}