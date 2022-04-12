//
// This file manually written from cef/include/internal/cef_types.h.
//

using System.Runtime.InteropServices;

namespace Xilium.CefGlue.Interop;

[StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
internal struct cef_audio_parameters_t
{
    public CefChannelLayout channel_layout;
    public int sample_rate;
    public int frames_per_buffer;
}