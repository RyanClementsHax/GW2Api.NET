﻿namespace GW2Api.NET.V2.Characters.Dto
{
    public record CraftingDiscipline(
        Discipline Discipline,
        int Rating,
        bool Active
    );
}