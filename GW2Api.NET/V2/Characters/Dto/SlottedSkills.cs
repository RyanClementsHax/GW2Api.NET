using System.Collections.Generic;

namespace GW2Api.NET.V2.Characters.Dto
{
    public record SlottedSkills(
        int? Heal,
        IList<int?> Utilities,
        int? Elite
    );
}