using System.Collections.Generic;

namespace GW2Api.NET.V1.Colors
{
    internal record ColorsResponse(
        IReadOnlyDictionary<string, Color> Colors
    );
}
