using System.Collections.Generic;

namespace GW2Api.NET.V1.Colors
{
    public record Color(
        string Id,
        string Name,
        IReadOnlyCollection<int> BaseRgb,
        ColorModel Cloth,
        ColorModel Leather,
        ColorModel Metal,
        int? Item,
        IReadOnlyCollection<string> Categories
    );
}
