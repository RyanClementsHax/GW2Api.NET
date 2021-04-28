using GW2Api.NET.V2.GameMechanics.Dto.Professions;
using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto.Specializations
{
    public record Specialization(
        int Id,
        string Name,
        Profession Profession,
        bool Elite,
        Uri Icon,
        string Background,
        IList<int> MinorTraits,
        IList<int> MajorTraits
    );
}
