using System;

namespace Xilium.CefGlue;

/// <summary>
///     Supported quick menu state bit flags.
/// </summary>
[Flags]
public enum CefQuickMenuEditStateFlags
{
    None = 0,
    CanEllipsis = 1 << 0,
    CanCut = 1 << 1,
    CanCopy = 1 << 2,
    CanPast = 1 << 3
}