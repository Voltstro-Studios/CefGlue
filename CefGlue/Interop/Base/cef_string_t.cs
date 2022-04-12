using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security;

namespace Xilium.CefGlue.Interop;

#pragma warning disable CS8825

[StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
internal unsafe struct cef_string_t
{
    internal char* _str;
    internal UIntPtr _length;
    internal IntPtr _dtor;

    [UnmanagedFunctionPointer(libcef.CEF_CALL)]
#if !DEBUG
        [SuppressUnmanagedCodeSecurity]
#endif
    public delegate void dtor_delegate(char* str);

    public cef_string_t(char* str, int length)
    {
        _str = str;
        _length = (UIntPtr) length;
        _dtor = IntPtr.Zero;
    }

    public static void Copy(string? value, cef_string_t* str)
    {
        fixed (char* value_ptr = value)
        {
            libcef.string_set(value_ptr, value != null ? (UIntPtr) value.Length : UIntPtr.Zero, str,
                1); // FIXME: do not ignore result
        }
    }

    [return: NotNullIfNotNull("obj")]
    public static string? ToString(cef_string_t* obj)
    {
        return obj == null ? null : new string(obj->_str, 0, (int) obj->_length);
    }
}

#pragma warning restore CS8825