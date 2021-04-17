using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto.Professions
{
    public record Training(
        int Id,
        TrainingCategory Category,
        string Name,
        IList<Track> Track
    );
}