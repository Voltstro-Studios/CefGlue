//
// This file manually written from cef/include/internal/cef_types.h.
//

using System.Runtime.InteropServices;

namespace Xilium.CefGlue.Interop;

[StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
internal struct cef_media_sink_device_info_t
{
    public cef_string_t ip_address;
    public int port;
    public cef_string_t model_name;
}