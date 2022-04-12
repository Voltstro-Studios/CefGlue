//
// This file manually written from cef/include/internal/cef_types.h.
//

using System.Runtime.InteropServices;

namespace Xilium.CefGlue.Interop;

[StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
internal struct cef_popup_features_t
{
    public int x;
    public int xSet;
    public int y;
    public int ySet;
    public int width;
    public int widthSet;
    public int height;
    public int heightSet;

    public int menuBarVisible;
    public int statusBarVisible;
    public int toolBarVisible;
    public int scrollbarsVisible;
}