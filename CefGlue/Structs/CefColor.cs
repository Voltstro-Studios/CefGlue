namespace Xilium.CefGlue;

public struct CefColor
{
    private readonly uint _value;

    public CefColor(uint argb)
    {
        _value = argb;
    }

    public CefColor(byte alpha, byte red, byte green, byte blue)
    {
        _value = unchecked((uint) ((alpha << 24) | (red << 16) | (green << 8) | blue));
    }

    public byte A => unchecked((byte) (_value >> 24));

    public byte R => unchecked((byte) (_value >> 16));

    public byte G => unchecked((byte) (_value >> 8));

    public byte B => unchecked((byte) _value);

    public uint ToArgb()
    {
        return _value;
    }
}