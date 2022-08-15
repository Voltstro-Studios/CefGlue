using Xilium.CefGlue.Interop;

namespace Xilium.CefGlue;

public struct CefTouchHandleState
{
    public int TouchHandleId { get; set; }
    
    public uint Flags { get; set; }
    
    public bool Enabled { get; set; }
    
    public CefHorizontalAlignment Orientation { get; set; }
    public int MirrorVertical { get; set; }
    public int MirrorHorizontal { get; set; }

    public CefPoint Origin { get; set; }

    public float Alpha { get; set; }

    internal static unsafe CefTouchHandleState FromNative(cef_touch_handle_state_t* touchHandleState)
    {
        return new CefTouchHandleState
        {
            TouchHandleId = touchHandleState->touch_handle_id,
            Flags = touchHandleState->flags,
            Enabled = touchHandleState->enabled != 0,
            Orientation = touchHandleState->orientation,
            MirrorVertical = touchHandleState->mirror_vertical,
            MirrorHorizontal = touchHandleState->mirror_horizontal,
            Origin = new CefPoint(touchHandleState->origin.x, touchHandleState->origin.y),
            Alpha = touchHandleState->alpha
        };
    }

    internal cef_touch_handle_state_t ToNative()
    {
        var result = new cef_touch_handle_state_t
        {
            touch_handle_id = TouchHandleId,
            flags = Flags,
            enabled = Enabled ? 0 : 1,
            orientation = Orientation,
            mirror_horizontal = MirrorHorizontal,
            mirror_vertical = MirrorVertical,
            origin = new cef_point_t(Origin.X, Origin.Y),
            alpha = Alpha
        };
        return result;
    }
}