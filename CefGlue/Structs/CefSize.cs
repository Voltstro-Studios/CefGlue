namespace Xilium.CefGlue;

public struct CefSize
{
    public CefSize(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int Width { get; set; }

    public int Height { get; set; }
}