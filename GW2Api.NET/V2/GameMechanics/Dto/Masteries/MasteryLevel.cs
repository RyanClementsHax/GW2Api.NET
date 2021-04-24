﻿namespace GW2Api.NET.V2.GameMechanics.Dto.Masteries
{
    public record MasteryLevel(
        string Name,
        string Description,
        string Instruction,
        string Icon,
        int PointCost,
        int ExpCost
    );
}