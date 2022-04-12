using System.Diagnostics;
using Xilium.CefGlue.Interop;

namespace Xilium.CefGlue;

/// <summary>
///     Structure representing mouse event information.
/// </summary>
public unsafe struct CefMouseEvent
{
    public CefMouseEvent(int x, int y, CefEventFlags modifiers)
    {
        X = x;
        Y = y;
        Modifiers = modifiers;
    }

    internal CefMouseEvent(cef_mouse_event_t* ptr)
    {
        Debug.Assert(ptr != null);

        X = ptr->x;
        Y = ptr->y;
        Modifiers = ptr->modifiers;
    }

    internal cef_mouse_event_t ToNative()
    {
        return new cef_mouse_event_t(X, Y, Modifiers);
    }

    public int X { get; set; }

    public int Y { get; set; }

    public CefEventFlags Modifiers { get; set; }
}