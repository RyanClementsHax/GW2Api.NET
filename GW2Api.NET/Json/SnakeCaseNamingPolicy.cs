using GW2Api.NET.Helpers;
using System.Text.Json;

namespace GW2Api.NET.Json
{
    internal class SnakeCaseNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name) => name.ToSnakeCase();
    }
}
