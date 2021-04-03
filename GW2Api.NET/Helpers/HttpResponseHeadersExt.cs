using GW2Api.NET.Exceptions;
using System;
using System.Linq;
using System.Net.Http.Headers;

namespace GW2Api.NET.Helpers
{
    internal static class HttpResponseHeadersExt
    {
        internal static int GetAsInt(this HttpResponseHeaders headers, string name)
        {
            string header;
            try
            {
                header = headers.GetValues(name).First();
            }
            catch (InvalidOperationException)
            {
                throw new ApiException($"Expected header {name} to be present in response, but wasn't there. Something is likely wrong with the GW2 Api.");
            }

            if (int.TryParse(header, out var headerAsInt))
            {
                return headerAsInt;
            }
            else
            {
                throw new ApiException($"Expected header {name} to be parsable to an int, but was {header}. Something is likely wrong with the GW2 Api.");
            }
        }
    }
}
