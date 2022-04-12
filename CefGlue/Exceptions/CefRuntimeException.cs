using System;

namespace Xilium.CefGlue;

public class CefRuntimeException : Exception
{
    public CefRuntimeException(string message)
        : base(message)
    {
    }
}