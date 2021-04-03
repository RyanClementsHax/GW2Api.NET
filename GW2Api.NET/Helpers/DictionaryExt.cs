using System.Collections.Generic;

namespace GW2Api.NET.Helpers
{
    public static class DictionaryExt
    {
        public static IDictionary<string, string> ConfigurePage(this IDictionary<string, string> paramMap, int page, int pageSize)
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
    }
}
