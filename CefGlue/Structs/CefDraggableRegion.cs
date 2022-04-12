using Xilium.CefGlue.Interop;

namespace Xilium.CefGlue;

public sealed class CefDraggableRegion
{
    private unsafe CefDraggableRegion(cef_draggable_region_t* ptr)
    {
        Bounds = new CefRectangle(
            ptr->bounds.x,
            ptr->bounds.y,
            ptr->bounds.width,
            ptr->bounds.height
        );
        Draggable = ptr->draggable != 0;
    }

    public CefRectangle Bounds { get; }

    public bool Draggable { get; }

    internal static unsafe CefDraggableRegion FromNative(cef_draggable_region_t* ptr)
    {
        return new CefDraggableRegion(ptr);
    }
}