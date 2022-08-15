using System;
using System.Runtime.InteropServices;

namespace Xilium.CefGlue.Interop;

[StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
internal struct cef_touch_handle_state_t
{
    public int touch_handle_id;
    public uint flags;
    public int enabled;

    public CefHorizontalAlignment orientation;
    public int mirror_vertical;
    public int mirror_horizontal;

    public cef_point_t origin;

    public float alpha;
}