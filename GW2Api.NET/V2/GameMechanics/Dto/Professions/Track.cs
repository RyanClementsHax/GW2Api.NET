namespace GW2Api.NET.V2.GameMechanics.Dto.Professions
{
    public record Track(
        int Cost,
        TrackType Type,
        int? SkillId,
        int? TraitId
    );
}
