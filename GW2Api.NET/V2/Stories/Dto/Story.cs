using GW2Api.NET.V2.GameMechanics.Dto.Races;
using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Stories.Dto
{
    public record Story(
        int Id,
        Guid Season,
        string Name,
        string Description,
        string Timeline,
        int Level,
        int Order,
        IList<Chapter> Chapters,
        IList<Race> Races,
        IList<StoryFlag> Flags
    );
}
