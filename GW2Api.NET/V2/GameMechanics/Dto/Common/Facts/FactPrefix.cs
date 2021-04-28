using System;

namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts
{
    public record FactPrefix(
        string Text,
        Uri Icon,
        string Status,
        string Description
    );
}