using System.Collections.Generic;

namespace GW2Api.NET.V1.Colors.Dto
{
    internal record GetAllColorsResponse(
        IDictionary<string, Color> Colors
    );
}
