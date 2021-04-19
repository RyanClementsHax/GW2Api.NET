using System;

namespace GW2Api.NET.V2.Guilds.Dto
{
    public record Guild(
        Guid Id,
        string Name,
        string Tag,
        int? Level,
        string Motd,
        int? Influence,
        string Aetherium,
        int? Favor,
        int? MemberCount,
        int? MemberCapacity,
        Emblem Emblem
    );
}
