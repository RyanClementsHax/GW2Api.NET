namespace GW2Api.NET.V2.GameMechanics.Dto.Skills.SkillFactTypes
{
    public record ComboFinisher(
        string Text,
        string Icon,

        int Percent,
        FinisherType FinisherType
    ) : SkillFact(
        Text,
        Icon
    );
}
