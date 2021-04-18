namespace GW2Api.NET.V2.GameMechanics.Dto.Skills.SkillFactTypes
{
    public record ComboField(
        string Text,
        string Icon,

        FieldType FieldType
    ) : SkillFact(
        Text,
        Icon
    );
}
