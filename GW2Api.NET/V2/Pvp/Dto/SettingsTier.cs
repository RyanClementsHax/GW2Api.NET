using System.Collections.Generic;

namespace GW2Api.NET.V2.Pvp.Dto
{
    public record SettingsTier(
        string Color,
        SettingsTierType Type,
        string Name,
        IList<double> Range
    );
}