using GW2Api.NET.V2.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GW2Api.NET.Helpers
{
    internal static class ParamMapExt
    {
        internal static IDictionary<string, string> TryAddSchemaVersion(this IDictionary<string, string> paramMap, string schemaVersion)
        {
            if (!paramMap.TryAdd("v", schemaVersion))
                throw new InvalidOperationException($"This library only supports schema version: {schemaVersion}");

            return paramMap;
        }

        internal static IDictionary<string, string> ConfigurePage(this IDictionary<string, string> paramMap, int page, int pageSize)
        {
            if (page != -1)
            {
                paramMap["page"] = page.ToString();
            }

            if (pageSize != -1)
            {
                paramMap["pageSize"] = pageSize.ToString();
            }

            return paramMap;
        }

        internal static IDictionary<string, string> AddIfAny(this IDictionary<string, string> paramMap, string key, IEnumerable<string> value)
        {
            if (!string.IsNullOrWhiteSpace(key) && value is not null && value.Any())
            {
                paramMap[key] = value.ToUrlParam();
            }

            return paramMap;
        }

        internal static IDictionary<string, string> AddIfAny(this IDictionary<string, string> paramMap, string key, Permissions value)
        {
            if (!string.IsNullOrWhiteSpace(key) && value is not Permissions.None)
            {
                paramMap[key] = value.ToUrlParam();
            }

            return paramMap;
        }
    }
}
