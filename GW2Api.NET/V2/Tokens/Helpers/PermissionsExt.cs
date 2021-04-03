using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Tokens.Helpers
{
    internal static class PermissionsExt
    {
        internal static IList<string> ToList(this Permissions permissions)
        {
            var list = new List<string>();

            foreach (Permissions permission in Enum.GetValues(typeof(Permissions)))
            {
                if ((permissions & permission) != 0) list.Add(permission.ToString().ToLower());
            }

            return list;
        }
    }
}
