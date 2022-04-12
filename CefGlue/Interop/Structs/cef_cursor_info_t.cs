using System.Runtime.InteropServices;

namespace Xilium.CefGlue.Interop;

[StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
internal unsafe struct cef_cursor_info_t
{
    public cef_point_t hotspot;
    public float image_scale_factor;
    public void* buffer;
    public cef_size_t size;
}