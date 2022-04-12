namespace Xilium.CefGlue;

public struct CefRange
{
    public CefRange(int from, int to)
    {
        From = from;
        To = to;
    }

    public int From { get; set; }

    public int To { get; set; }
}