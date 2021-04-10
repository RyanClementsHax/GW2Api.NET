using System.Collections.Generic;

namespace GW2Api.NET.V2.Items.Dto.ItemTypes.Gizmo
{
    public record GizmoDetails(
        GizmoType Type,
        int? GuildUpgradeId,
        IList<int> VendorIds
    );
}
