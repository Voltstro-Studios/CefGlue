namespace Xilium.CefGlue;

public struct CefPoint
{
    public CefPoint(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; set; }

    public int Y { get; set; }
}