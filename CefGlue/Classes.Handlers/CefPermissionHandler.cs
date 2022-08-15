using Xilium.CefGlue.Interop;

namespace Xilium.CefGlue;

/// <summary>
///     Callback interface used for asynchronous continuation of media access
///     permission requests.
/// </summary>
public abstract partial class CefPermissionHandler
{
    private unsafe int on_request_media_access_permission(cef_permission_handler_t* self, cef_browser_t* browser,
        cef_frame_t* frame, cef_string_t* requesting_origin, uint requested_permissions,
        cef_media_access_callback_t* callback)
    {
        CheckSelf(self);
        
        var mBrowser = CefBrowser.FromNative(browser);
        var mFrame = CefFrame.FromNative(frame);
        var mRequestingOrigin = cef_string_t.ToString(requesting_origin);
        var mCallback = CefMediaAccessCallback.FromNative(callback);

        var result = OnRequestMediaAccessPermission(mBrowser, mFrame, mRequestingOrigin, requested_permissions, 
            mCallback);
        
        return result ? 1 : 0;
    }

    /// <summary>
    ///     Called when a page requests permission to access media. |requesting_origin|
    ///     is the URL origin requesting permission. |requested_permissions| is a
    ///     combination of values from cef_media_access_permission_types_t that
    ///     represent the requested permissions. Return true and call
    ///     CefMediaAccessCallback methods either in this method or at a later time to
    ///     continue or cancel the request. Return false to proceed with default
    ///     handling. With the Chrome runtime, default handling will display the
    ///     permission request UI. With the Alloy runtime, default handling will deny
    ///     the request. This method will not be called if the "--enable-media-stream"
    ///     command-line switch is used to grant all permissions.
    /// </summary>
    protected virtual bool OnRequestMediaAccessPermission(CefBrowser browser, CefFrame frame, string requestingOrigin,
        uint requestedPermissions, CefMediaAccessCallback callback)
    {
        return false;
    }

    
    private unsafe int on_show_permission_prompt(cef_permission_handler_t* self, cef_browser_t* browser, ulong prompt_id,
        cef_string_t* requesting_origin, uint requested_permissions, cef_permission_prompt_callback_t* callback)
    {
        CheckSelf(self);

        var mBrowser = CefBrowser.FromNative(browser);
        var mRequestingOrigin = cef_string_t.ToString(requesting_origin);
        var mCallback = CefPermissionPromptCallback.FromNative(callback);

        var result = OnShowPermissionPromt(mBrowser, prompt_id, mRequestingOrigin, requested_permissions, mCallback);
        
        return result ? 1 : 0;
    }

    /// <summary>
    ///      Called when a page should show a permission prompt. |prompt_id| uniquely
    ///     identifies the prompt. |requesting_origin| is the URL origin requesting
    ///     permission. |requested_permissions| is a combination of values from
    ///     cef_permission_request_types_t that represent the requested permissions.
    ///     Return true and call CefPermissionPromptCallback::Continue either in this
    ///     method or at a later time to continue or cancel the request. Return false
    ///     to proceed with default handling. With the Chrome runtime, default handling
    ///     will display the permission prompt UI. With the Alloy runtime, default
    ///     handling is CEF_PERMISSION_RESULT_IGNORE.
    /// </summary>
    protected virtual bool OnShowPermissionPromt(CefBrowser browser, ulong promptId, string requestingOrigin,
        uint requestedPermissions, CefPermissionPromptCallback callback)
    {
        return false;
    }

    
    private unsafe void on_dismiss_permission_prompt(cef_permission_handler_t* self, cef_browser_t* browser,
        ulong prompt_id, CefPermissionRequestResult result)
    {
        CheckSelf(self);

        var mBrowser = CefBrowser.FromNative(browser);

        OnDismissPermissionPromt(mBrowser, prompt_id, result);
    }

    protected virtual void OnDismissPermissionPromt(CefBrowser browser, ulong promptId,
        CefPermissionRequestResult result)
    {
    }
}