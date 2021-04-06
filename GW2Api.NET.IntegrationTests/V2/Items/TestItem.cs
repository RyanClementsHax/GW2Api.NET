using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace GW2Api.NET.IntegrationTests.V2.Items
{
    public record TestItem(
        int Id,
        IEnumerable<(string, string)> TwoLetterLangToNameMap,
        Type Type
    )
    {
        public IEnumerable<(CultureInfo, string)> LangToNameMap => TwoLetterLangToNameMap.Select(x => x.Item1 is null ? (null, x.Item2) : (new CultureInfo(x.Item1), x.Item2));
    };
}
