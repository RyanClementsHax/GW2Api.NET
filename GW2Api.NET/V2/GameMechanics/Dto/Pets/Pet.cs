using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto.Pets
{
    public record Pet(
        int Id,
        string Name,
        string Description,
        string Icon,
        IList<PetSkill> Skills
    );
}
