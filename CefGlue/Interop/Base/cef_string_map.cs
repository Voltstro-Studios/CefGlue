﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Xilium.CefGlue.Interop;

#pragma warning disable CS8825

[StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
internal unsafe struct cef_string_map
{
    [return: NotNullIfNotNull("map")]
    public static Dictionary<string, string>? ToDictionary(cef_string_map* map)
    {
        if (map == null)
            return null;

        var result = new Dictionary<string, string>();
        var count = libcef.string_map_size(map);
        if (count == 0) return result;

        var n_value = new cef_string_t();

        for (var i = 0; i < count; i++)
        {
            libcef.string_map_key(map, i, &n_value); // FIXME: do not ignore return value of libcef.string_map_key
            var key = cef_string_t.ToString(&n_value);
            libcef.string_map_value(map, i, &n_value); // FIXME: do not ignore return value of libcef.string_map_value
            var value = cef_string_t.ToString(&n_value);
            result.Add(key, value);
        }

        libcef.string_clear(&n_value);

        return result;
    }
}

#pragma warning restore CS8825