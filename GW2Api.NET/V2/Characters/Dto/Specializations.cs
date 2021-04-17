using System.Collections.Generic;

namespace GW2Api.NET.V2.Characters.Dto
{
    public record Specializations(
        IList<CharacterSpecialization> Pve,
        IList<CharacterSpecialization> Pvp,
        IList<CharacterSpecialization> Wvw
    );
}
