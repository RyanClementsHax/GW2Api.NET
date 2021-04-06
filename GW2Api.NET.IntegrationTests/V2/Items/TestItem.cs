using System;
using System.Globalization;

namespace GW2Api.NET.IntegrationTests.V2.Items
{
    public record TestItem(
        int Id,
        string Name,
        Type Type,
        string TwoLetterLang = null
    )
    {
        public CultureInfo Lang => TwoLetterLang is null ? null : new CultureInfo(TwoLetterLang);
    };
}
