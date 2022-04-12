//
// This file manually written from cef/include/internal/cef_types.h.
//

using System.Runtime.InteropServices;

namespace Xilium.CefGlue.Interop;

[StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
internal struct cef_point_t
{
    public int x;
    public int y;

    public cef_point_t(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}