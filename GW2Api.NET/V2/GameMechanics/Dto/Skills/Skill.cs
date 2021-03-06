﻿using GW2Api.NET.V2.GameMechanics.Dto.Common.Facts;
using GW2Api.NET.V2.GameMechanics.Dto.Professions;
using GW2Api.NET.V2.Items.Dto.ItemTypes.Weapon;
using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto.Skills
{
    public record Skill(
        int Id,
        string Name,
        string Description,
        Uri Icon,
        string ChatLink,
        SkillType? Type,
        WeaponType? WeaponType,
        IList<Profession> Profession,
        IList<SkillFlag> Flags,
        SkillSlot? Slot,
        IList<Fact> Facts,
        IList<Fact> TraitedFacts,
        IList<SkillCategory> Categories,
        Attunement? Attunement,
        int? Cost,
        string DualWield,
        int? FlipSkill,
        int? Initiative,
        int? NextChain,
        int? PrevChain,
        IList<int> TransformSkills,
        IList<int> BundleSkills,
        int? ToolbeltSkill
    );
}
