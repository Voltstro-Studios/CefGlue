//
// This file manually written from cef/include/internal/cef_types.h.
//

using System.Runtime.InteropServices;

namespace Xilium.CefGlue.Interop;

[StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
internal struct cef_screen_info_t
{
    public float device_scale_factor;
    public int depth;
    public int depth_per_component;
    public int is_monochrome;
    public cef_rect_t rect;
    public cef_rect_t available_rect;
}