using GW2Api.NET.V2.GameMechanics.Dto.Professions;
using GW2Api.NET.V2.GameMechanics.Dto.Races;
using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Characters.Dto
{
    public record Character(
        string Name,
        Race Race,
        Gender Gender,
        IList<string> Flags,
        Profession Profession,
        int Level,
        Guid? Guild,
        int Age,
        DateTimeOffset Created,
        int Deaths,
        IList<CraftingDiscipline> Crafting,
        int? Title,
        IList<string> Backstory,
        IList<WvwAbility> WvwAbilities,
        IList<Equipment> Equipment,
        IList<int> Recipes,
        EquipmentPvp EquipmentPvp,
        IList<CharacterTraining> Training,
        IList<Bag> Bags,
        Specializations Specializations,
        Skills Skills
    );
}
