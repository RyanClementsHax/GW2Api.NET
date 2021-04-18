﻿namespace GW2Api.NET.V2.GameMechanics.Dto.Skills.SkillFactTypes
{
    public record PrefixedBuff(
        string Text,
        string Icon,

        string Status,
        string Description,
        int? ApplyCount,
        int? Duration,
        FactPrefix Prefix
    ) : SkillFact(
        Text,
        Icon
    );
}
