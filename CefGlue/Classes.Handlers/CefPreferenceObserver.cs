using Xilium.CefGlue.Interop;

namespace Xilium.CefGlue;

public abstract unsafe partial class CefPreferenceObserver
{
    private void on_preference_changed(cef_preference_observer_t* self, cef_string_t* name)
    {
        CheckSelf(self);
        
        var name_m = cef_string_t.ToString(name);
        OnPreferenceChanged(name_m);
    }

    /// <summary>
    /// Called when a preference has changed. The new value can be retrieved using
    /// CefPreferenceManager::GetPreference.
    /// </summary>
    /// <param name="name"></param>
    public virtual void OnPreferenceChanged(string name)
    {
    }
}