//
// This file manually written from cef/include/internal/cef_types.h.
//

using System.Runtime.InteropServices;

namespace Xilium.CefGlue.Interop;

[StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
internal struct cef_range_t
{
    public int from;
    public int to;

    public cef_range_t(int from, int to)
    {
        this.from = from;
        this.to = to;
    }
}