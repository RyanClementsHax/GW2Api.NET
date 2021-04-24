using System.Collections.Generic;
using System.Numerics;

namespace GW2Api.NET.V2.Colors.Dto
{
    public record Color(
        int Id,
        string Name,
        Vector3 BaseRgb,
        ColorDetails Cloth,
        ColorDetails Leather,
        ColorDetails Metal,
        ColorDetails Fur,
        int? Item,
        IList<ColorCategory> Categories
    );
}
