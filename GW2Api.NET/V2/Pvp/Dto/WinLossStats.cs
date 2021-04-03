namespace GW2Api.NET.V2.Pvp.Dto
{
    public record WinLossStats(
        int Wins,
        int Losses,
        int Desertions,
        int Byes,
        int Forfeits
    );
}