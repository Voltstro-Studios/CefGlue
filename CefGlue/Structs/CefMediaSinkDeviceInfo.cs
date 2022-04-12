namespace Xilium.CefGlue;

/// <summary>
///     Device information for a MediaSink object.
/// </summary>
public readonly struct CefMediaSinkDeviceInfo
{
    public CefMediaSinkDeviceInfo(string? ipAddress, int port, string? modelName)
    {
        IPAddress = ipAddress;
        Port = port;
        ModelName = modelName;
    }

    public string? IPAddress { get; }

    public int Port { get; }

    public string? ModelName { get; }
}