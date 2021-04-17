using GW2Api.NET.V2.GameMechanics.Dto.Professions;
using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Pvp.Dto
{
    public record PvpGame(
        Guid Id,
        int MapId,
        DateTimeOffset Started,
        DateTimeOffset Ended,
        Result Result,
        Team Team,
        Profession Profession,
        IDictionary<Team, int> Scores,
        RatingType RatingType,
        int RatingChange,
        Guid? Season
    );
}
