using System;

namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    public record Buff(
        string Text,
        Uri Icon,
        int? RequiresTrait,
        int? Overrides,

        string Status,
        string Description,
        int? ApplyCount,
        int? Duration
    ) : Fact(
        Text,
        Icon,
        RequiresTrait,
        Overrides
    );
}
