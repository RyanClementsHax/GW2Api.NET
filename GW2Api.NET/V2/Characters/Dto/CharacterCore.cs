using System;

namespace GW2Api.NET.V2.Characters.Dto
{
    public record CharacterCore(
        string Name,
        Race Race,
        Gender Gender,
        Profession Profession,
        int Level,
        Guid? Guild,
        int Age,
        DateTimeOffset Created,
        int Deaths,
        int? Title
    );
}
