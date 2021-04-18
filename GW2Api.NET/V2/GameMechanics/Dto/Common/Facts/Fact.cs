using GW2Api.NET.Json.Converters;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts
{
    [JsonConverter(typeof(AbstractClassConverter<Fact>))]
    public abstract record Fact(
        string Text,
        string Icon,
        int? RequiresTrait,
        int? Overrides
    );
}