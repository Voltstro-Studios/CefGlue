using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Xilium.CefGlue.Interop;

namespace Xilium.CefGlue
{
    /// <summary>
    /// Implement this interface to handle events related to browser requests. The
    /// methods of this class will be called on the thread indicated.
    /// </summary>
    public abstract unsafe partial class CefRequestHandler
    {
        private int on_before_browse(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, int user_gesture, int is_redirect)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefRequestHandler.OnBeforeBrowse
        }
        
        /// <summary>
        /// Called on the UI thread before browser navigation. Return true to cancel
        /// the navigation or false to allow the navigation to proceed. The |request|
        /// object cannot be modified in this callback.
        /// CefLoadHandler::OnLoadingStateChange will be called twice in all cases.
        /// If the navigation is allowed CefLoadHandler::OnLoadStart and
        /// CefLoadHandler::OnLoadEnd will be called. If the navigation is canceled
        /// CefLoadHandler::OnLoadError will be called with an |errorCode| value of
        /// ERR_ABORTED. The |user_gesture| value will be true if the browser
        /// navigated via explicit user gesture (e.g. clicking a link) or false if it
        /// navigated automatically (e.g. via the DomContentLoaded event).
        /// </summary>
        // protected abstract int OnBeforeBrowse(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, int user_gesture, int is_redirect);
        
        private int on_open_urlfrom_tab(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_string_t* target_url, CefWindowOpenDisposition target_disposition, int user_gesture)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefRequestHandler.OnOpenURLFromTab
        }
        
        /// <summary>
        /// Called on the UI thread before OnBeforeBrowse in certain limited cases
        /// where navigating a new or different browser might be desirable. This
        /// includes user-initiated navigation that might open in a special way (e.g.
        /// links clicked via middle-click or ctrl + left-click) and certain types of
        /// cross-origin navigation initiated from the renderer process (e.g.
        /// navigating the top-level frame to/from a file URL). The |browser| and
        /// |frame| values represent the source of the navigation. The
        /// |target_disposition| value indicates where the user intended to navigate
        /// the browser based on standard Chromium behaviors (e.g. current tab,
        /// new tab, etc). The |user_gesture| value will be true if the browser
        /// navigated via explicit user gesture (e.g. clicking a link) or false if it
        /// navigated automatically (e.g. via the DomContentLoaded event). Return true
        /// to cancel the navigation or false to allow the navigation to proceed in the
        /// source browser's top-level frame.
        /// </summary>
        // protected abstract int OnOpenURLFromTab(cef_browser_t* browser, cef_frame_t* frame, cef_string_t* target_url, CefWindowOpenDisposition target_disposition, int user_gesture);
        
        private cef_resource_request_handler_t* get_resource_request_handler(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, int is_navigation, int is_download, cef_string_t* request_initiator, int* disable_default_handling)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefRequestHandler.GetResourceRequestHandler
        }
        
        /// <summary>
        /// Called on the browser process IO thread before a resource request is
        /// initiated. The |browser| and |frame| values represent the source of the
        /// request. |request| represents the request contents and cannot be modified
        /// in this callback. |is_navigation| will be true if the resource request is a
        /// navigation. |is_download| will be true if the resource request is a
        /// download. |request_initiator| is the origin (scheme + domain) of the page
        /// that initiated the request. Set |disable_default_handling| to true to
        /// disable default handling of the request, in which case it will need to be
        /// handled via CefResourceRequestHandler::GetResourceHandler or it will be
        /// canceled. To allow the resource load to proceed with default handling
        /// return NULL. To specify a handler for the resource return a
        /// CefResourceRequestHandler object. If this callback returns NULL the same
        /// method will be called on the associated CefRequestContextHandler, if any.
        /// </summary>
        // protected abstract cef_resource_request_handler_t* GetResourceRequestHandler(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, int is_navigation, int is_download, cef_string_t* request_initiator, int* disable_default_handling);
        
        private int get_auth_credentials(cef_request_handler_t* self, cef_browser_t* browser, cef_string_t* origin_url, int isProxy, cef_string_t* host, int port, cef_string_t* realm, cef_string_t* scheme, cef_auth_callback_t* callback)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefRequestHandler.GetAuthCredentials
        }
        
        /// <summary>
        /// Called on the IO thread when the browser needs credentials from the user.
        /// |origin_url| is the origin making this authentication request. |isProxy|
        /// indicates whether the host is a proxy server. |host| contains the hostname
        /// and |port| contains the port number. |realm| is the realm of the challenge
        /// and may be empty. |scheme| is the authentication scheme used, such as
        /// "basic" or "digest", and will be empty if the source of the request is an
        /// FTP server. Return true to continue the request and call
        /// CefAuthCallback::Continue() either in this method or at a later time when
        /// the authentication information is available. Return false to cancel the
        /// request immediately.
        /// </summary>
        // protected abstract int GetAuthCredentials(cef_browser_t* browser, cef_string_t* origin_url, int isProxy, cef_string_t* host, int port, cef_string_t* realm, cef_string_t* scheme, cef_auth_callback_t* callback);
        
        private int on_quota_request(cef_request_handler_t* self, cef_browser_t* browser, cef_string_t* origin_url, long new_size, cef_request_callback_t* callback)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefRequestHandler.OnQuotaRequest
        }
        
        /// <summary>
        /// Called on the IO thread when JavaScript requests a specific storage quota
        /// size via the webkitStorageInfo.requestQuota function. |origin_url| is the
        /// origin of the page making the request. |new_size| is the requested quota
        /// size in bytes. Return true to continue the request and call
        /// CefRequestCallback::Continue() either in this method or at a later time to
        /// grant or deny the request. Return false to cancel the request immediately.
        /// </summary>
        // protected abstract int OnQuotaRequest(cef_browser_t* browser, cef_string_t* origin_url, long new_size, cef_request_callback_t* callback);
        
        private int on_certificate_error(cef_request_handler_t* self, cef_browser_t* browser, CefErrorCode cert_error, cef_string_t* request_url, cef_sslinfo_t* ssl_info, cef_request_callback_t* callback)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefRequestHandler.OnCertificateError
        }
        
        /// <summary>
        /// Called on the UI thread to handle requests for URLs with an invalid
        /// SSL certificate. Return true and call CefRequestCallback::Continue() either
        /// in this method or at a later time to continue or cancel the request. Return
        /// false to cancel the request immediately. If
        /// CefSettings.ignore_certificate_errors is set all invalid certificates will
        /// be accepted without calling this method.
        /// </summary>
        // protected abstract int OnCertificateError(cef_browser_t* browser, CefErrorCode cert_error, cef_string_t* request_url, cef_sslinfo_t* ssl_info, cef_request_callback_t* callback);
        
        private int on_select_client_certificate(cef_request_handler_t* self, cef_browser_t* browser, int isProxy, cef_string_t* host, int port, UIntPtr certificatesCount, cef_x509certificate_t** certificates, cef_select_client_certificate_callback_t* callback)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefRequestHandler.OnSelectClientCertificate
        }
        
        /// <summary>
        /// Called on the UI thread when a client certificate is being requested for
        /// authentication. Return false to use the default behavior and automatically
        /// select the first certificate available. Return true and call
        /// CefSelectClientCertificateCallback::Select either in this method or at a
        /// later time to select a certificate. Do not call Select or call it with NULL
        /// to continue without using any certificate. |isProxy| indicates whether the
        /// host is an HTTPS proxy or the origin server. |host| and |port| contains the
        /// hostname and port of the SSL server. |certificates| is the list of
        /// certificates to choose from; this list has already been pruned by Chromium
        /// so that it only contains certificates from issuers that the server trusts.
        /// </summary>
        // protected abstract int OnSelectClientCertificate(cef_browser_t* browser, int isProxy, cef_string_t* host, int port, UIntPtr certificatesCount, cef_x509certificate_t** certificates, cef_select_client_certificate_callback_t* callback);
        
        private void on_plugin_crashed(cef_request_handler_t* self, cef_browser_t* browser, cef_string_t* plugin_path)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefRequestHandler.OnPluginCrashed
        }
        
        /// <summary>
        /// Called on the browser process UI thread when a plugin has crashed.
        /// |plugin_path| is the path of the plugin that crashed.
        /// </summary>
        // protected abstract void OnPluginCrashed(cef_browser_t* browser, cef_string_t* plugin_path);
        
        private void on_render_view_ready(cef_request_handler_t* self, cef_browser_t* browser)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefRequestHandler.OnRenderViewReady
        }
        
        /// <summary>
        /// Called on the browser process UI thread when the render view associated
        /// with |browser| is ready to receive/handle IPC messages in the render
        /// process.
        /// </summary>
        // protected abstract void OnRenderViewReady(cef_browser_t* browser);
        
        private void on_render_process_terminated(cef_request_handler_t* self, cef_browser_t* browser, CefTerminationStatus status)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefRequestHandler.OnRenderProcessTerminated
        }
        
        /// <summary>
        /// Called on the browser process UI thread when the render process
        /// terminates unexpectedly. |status| indicates how the process
        /// terminated.
        /// </summary>
        // protected abstract void OnRenderProcessTerminated(cef_browser_t* browser, CefTerminationStatus status);
        
        private void on_document_available_in_main_frame(cef_request_handler_t* self, cef_browser_t* browser)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefRequestHandler.OnDocumentAvailableInMainFrame
        }
        
        /// <summary>
        /// Called on the browser process UI thread when the window.document object of
        /// the main frame has been created.
        /// </summary>
        // protected abstract void OnDocumentAvailableInMainFrame(cef_browser_t* browser);
        
    }
}
