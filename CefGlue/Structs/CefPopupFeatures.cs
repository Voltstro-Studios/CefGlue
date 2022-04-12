using Xilium.CefGlue.Interop;

namespace Xilium.CefGlue;

public sealed unsafe class CefPopupFeatures
{
    private cef_popup_features_t* _self;

    internal CefPopupFeatures(cef_popup_features_t* ptr)
    {
        _self = ptr;
    }

    public int? X
    {
        get
        {
            ThrowIfObjectDisposed();
            return _self->xSet != 0 ? _self->x : null;
        }
    }

    public int? Y
    {
        get
        {
            ThrowIfObjectDisposed();
            return _self->ySet != 0 ? _self->y : null;
        }
    }

    public int? Width
    {
        get
        {
            ThrowIfObjectDisposed();
            return _self->widthSet != 0 ? _self->width : null;
        }
    }

    public int? Height
    {
        get
        {
            ThrowIfObjectDisposed();
            return _self->heightSet != 0 ? _self->height : null;
        }
    }

    public bool MenuBarVisible
    {
        get
        {
            ThrowIfObjectDisposed();
            return _self->menuBarVisible != 0;
        }
    }

    public bool StatusBarVisible
    {
        get
        {
            ThrowIfObjectDisposed();
            return _self->statusBarVisible != 0;
        }
    }

    public bool ToolBarVisible
    {
        get
        {
            ThrowIfObjectDisposed();
            return _self->toolBarVisible != 0;
        }
    }

    public bool ScrollbarsVisible
    {
        get
        {
            ThrowIfObjectDisposed();
            return _self->scrollbarsVisible != 0;
        }
    }

    internal void Dispose()
    {
        _self = null;
    }

    private void ThrowIfObjectDisposed()
    {
        if (_self == null) throw ExceptionBuilder.ObjectDisposed();
    }
}