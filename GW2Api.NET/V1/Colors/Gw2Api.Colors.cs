﻿using GW2Api.NET.V1.Colors;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial class Gw2ApiV1
    {
        private static readonly string _colorsResource = "colors.json";

        public async Task<IDictionary<string, Color>> GetAllColorsAsync(CultureInfo cultureInfo)
        {
            if (cultureInfo is null) throw new ArgumentNullException(nameof(cultureInfo));

            return (await GetAsync<ColorsResponse>(
                _colorsResource,
                new Dictionary<string, string>
                {
                    { "lang", cultureInfo.TwoLetterISOLanguageName }
                }
            )).Colors.ToDictionary(
                x => x.Key,
                x => x.Value with
                {
                    ColorId = x.Key
                }
            );
        }

        public async Task<IDictionary<string, Color>> GetAllColorsAsync(CultureInfo cultureInfo, CancellationToken token)
        {
            if (cultureInfo is null) throw new ArgumentNullException(nameof(cultureInfo));

            return (await GetAsync<ColorsResponse>(
                _colorsResource,
                new Dictionary<string, string>
                {
                    { "lang", cultureInfo.TwoLetterISOLanguageName }
                },
                token
            )).Colors.ToDictionary(
                x => x.Key,
                x => x.Value with
                {
                    ColorId = x.Key
                }
            );
        }
    }
}