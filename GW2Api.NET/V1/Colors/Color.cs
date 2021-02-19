using System.Collections.Generic;
using System.Numerics;

namespace GW2Api.NET.V1.Colors
{
    public record Color(
        string Id,
        string Name,
        Vector3 BaseRgb,
        ColorModel Cloth,
        ColorModel Leather,
        ColorModel Metal,
        int? Item,
        IReadOnlyCollection<string> Categories
    );
}
