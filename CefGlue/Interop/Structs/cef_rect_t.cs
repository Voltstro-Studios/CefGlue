//
// This file manually written from cef/include/internal/cef_types.h.
//

using System.Runtime.InteropServices;

namespace Xilium.CefGlue.Interop;

[StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
internal struct cef_rect_t
{
    public int x;
    public int y;
    public int width;
    public int height;

    public cef_rect_t(int x, int y, int width, int height)
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }
}