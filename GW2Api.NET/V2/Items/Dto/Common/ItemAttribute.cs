namespace GW2Api.NET.V2.Items.Dto.Common
{
    public record ItemAttribute(
        AttributeType Attribute,
        double? Multiplier,
        int? Modifier,
        int? Value
    );
}
