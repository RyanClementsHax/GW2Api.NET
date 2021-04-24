using System.Collections.Generic;

namespace GW2Api.NET.V2.Stories.Dto
{
    public record Quest(
        int Id,
        string Name,
        int Level,
        int Story,
        IList<Goal> Goals
    );
}
