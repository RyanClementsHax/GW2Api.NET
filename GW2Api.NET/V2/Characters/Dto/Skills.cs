namespace GW2Api.NET.V2.Characters.Dto
{
    public record Skills(
        SlottedSkills Pve,
        SlottedSkills Pvp,
        SlottedSkills Wvw
    );
}
