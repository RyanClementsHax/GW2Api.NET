using System.Collections.Generic;

namespace GW2Api.NET.V2.Characters.Dto
{
    public record CharacterSpecialization(
        int Id,
        IList<int?> Traits
    );
}