using GW2Api.NET.Json.Converters;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Bag
{
    public record BagSubDetail(
        [property: JsonConverter(typeof(StringToBooleanConverter))] bool NoSellOrSort,
        [property: JsonConverter(typeof(StringToIntConverter))] int Size
    );
}
