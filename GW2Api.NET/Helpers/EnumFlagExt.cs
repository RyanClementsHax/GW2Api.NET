using System;
using System.Collections.Generic;
using System.Linq;

namespace GW2Api.NET.Helpers
{
    public static class EnumFlagExt
    {
        internal static IList<T> ToList<T>(this T flags) where T : struct, IConvertible
        {
            var flagsAsInt = (int)(object)flags;
            var list = new List<T>();

            foreach (T flag in Enum.GetValues(typeof(T)))
            {
                if ((flagsAsInt & (int)(object)flag) != 0) list.Add(flag);
            }

            return list;
        }

        internal static T Combine<T>(this IEnumerable<T> permissions) where T : struct, IConvertible
            => (T)(object)permissions.Aggregate(0, (acc, curr) => (int)(object)acc | (int)(object)curr);
    }
}
