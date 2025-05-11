using Xilium.CefGlue.Interop;

namespace Xilium.CefGlue;

public abstract unsafe partial class CefSettingObserver
{
    private void on_setting_changed(cef_setting_observer_t* self, cef_string_t* requesting_url,
        cef_string_t* top_level_url, CefContentSettingTypes content_type)
    {
        CheckSelf(self);

        string requestingUrl = cef_string_t.ToString(requesting_url);
        string topLevelUrl = cef_string_t.ToString(top_level_url);
        OnSettingChanged(requestingUrl, topLevelUrl, content_type);
    }

    /// <summary>
    /// Called when a content or website setting has changed. The new value can be
    /// retrieved using CefRequestContext::GetContentSetting or
    /// CefRequestContext::GetWebsiteSetting.
    /// </summary>
    /// <param name="requestingUrl"></param>
    /// <param name="topLevelUrl"></param>
    /// <param name="contentType"></param>
    public virtual void OnSettingChanged(string requestingUrl, string topLevelUrl, CefContentSettingTypes contentType)
    {
    }
}