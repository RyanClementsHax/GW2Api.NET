using System.Linq;

namespace GW2Api.NET.Helpers
{
    internal static class StringExt
    {
        public static string ToSnakeCase(this string str)
            => string.Concat(
                str.Select((x, i) =>
                    i > 0 && char.IsUpper(x)
                        ? "_" + x
                        : x.ToString()
                )
            ).ToLower();
    }
}
