using System.Collections.Generic;

namespace GW2Api.NET.V2.Characters.Dto
{
    public record Specializations(
        IList<Specialization> Pve,
        IList<Specialization> Pvp,
        IList<Specialization> Wvw
    );
}
