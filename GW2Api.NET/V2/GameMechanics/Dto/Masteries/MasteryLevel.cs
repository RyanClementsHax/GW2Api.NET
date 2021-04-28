using System;

namespace GW2Api.NET.V2.GameMechanics.Dto.Masteries
{
    public record MasteryLevel(
        string Name,
        string Description,
        string Instruction,
        Uri Icon,
        int PointCost,
        int ExpCost
    );
}
