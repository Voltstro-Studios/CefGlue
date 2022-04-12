//
// This file manually written from cef/include/internal/cef_types.h.
//

using System.Runtime.InteropServices;

namespace Xilium.CefGlue.Interop;

[StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
internal struct cef_size_t
{
    public int width;
    public int height;

    public cef_size_t(int width, int height)
    {
        this.width = width;
        this.height = height;
    }
}