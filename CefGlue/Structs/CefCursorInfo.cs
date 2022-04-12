using System;
using System.Runtime.InteropServices;
using Xilium.CefGlue.Interop;

namespace Xilium.CefGlue;

/// <summary>
///     Structure representing cursor information. |buffer| will be
///     |size.width|*|size.height|*4 bytes in size and represents a BGRA image with
///     an upper-left origin.
/// </summary>
public sealed unsafe class CefCursorInfo
{
    private cef_cursor_info_t* _ptr;

    internal CefCursorInfo(cef_cursor_info_t* ptr)
    {
        _ptr = ptr;
    }

    public CefPoint HotSpot
    {
        get
        {
            ThrowIfDisposed();
            return new CefPoint(_ptr->hotspot.x, _ptr->hotspot.y);
        }
    }

    public float ImageScaleFactor
    {
        get
        {
            ThrowIfDisposed();
            return _ptr->image_scale_factor;
        }
    }

    public CefSize Size
    {
        get
        {
            ThrowIfDisposed();
            return new CefSize(_ptr->size.width, _ptr->size.height);
        }
    }

    internal void Dispose()
    {
        _ptr = null;
    }

    private void ThrowIfDisposed()
    {
        if (_ptr == null) throw new ObjectDisposedException("CefCursorInfo");
    }

    public byte[] GetBuffer()
    {
        ThrowIfDisposed();
        var bufferLength = _ptr->size.width * _ptr->size.height * 4;
        var bytes = new byte[bufferLength];
        Marshal.Copy((IntPtr) _ptr->buffer, bytes, 0, bufferLength);
        return bytes;
    }
}