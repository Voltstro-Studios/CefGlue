using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Xilium.CefGlue.Interop;

namespace Xilium.CefGlue
{
    /// <summary>
    /// Object representing an extension. Methods may be called on any thread unless
    /// otherwise indicated.
    /// </summary>
    public sealed unsafe partial class CefExtension
    {
        /// <summary>
        /// Returns the unique extension identifier. This is calculated based on the
        /// extension public key, if available, or on the extension path. See
        /// https://developer.chrome.com/extensions/manifest/key for details.
        /// </summary>
        public cef_string_userfree* GetIdentifier()
        {
            throw new NotImplementedException(); // TODO: CefExtension.GetIdentifier
        }
        
        /// <summary>
        /// Returns the absolute path to the extension directory on disk. This value
        /// will be prefixed with PK_DIR_RESOURCES if a relative path was passed to
        /// CefRequestContext::LoadExtension.
        /// </summary>
        public cef_string_userfree* GetPath()
        {
            throw new NotImplementedException(); // TODO: CefExtension.GetPath
        }
        
        /// <summary>
        /// Returns the extension manifest contents as a CefDictionaryValue object. See
        /// https://developer.chrome.com/extensions/manifest for details.
        /// </summary>
        public cef_dictionary_value_t* GetManifest()
        {
            throw new NotImplementedException(); // TODO: CefExtension.GetManifest
        }
        
        /// <summary>
        /// Returns true if this object is the same extension as |that| object.
        /// Extensions are considered the same if identifier, path and loader context
        /// match.
        /// </summary>
        public int IsSame(cef_extension_t* that)
        {
            throw new NotImplementedException(); // TODO: CefExtension.IsSame
        }
        
        /// <summary>
        /// Returns the handler for this extension. Will return NULL for internal
        /// extensions or if no handler was passed to CefRequestContext::LoadExtension.
        /// </summary>
        public cef_extension_handler_t* GetHandler()
        {
            throw new NotImplementedException(); // TODO: CefExtension.GetHandler
        }
        
        /// <summary>
        /// Returns the request context that loaded this extension. Will return NULL
        /// for internal extensions or if the extension has been unloaded. See the
        /// CefRequestContext::LoadExtension documentation for more information about
        /// loader contexts. Must be called on the browser process UI thread.
        /// </summary>
        public cef_request_context_t* GetLoaderContext()
        {
            throw new NotImplementedException(); // TODO: CefExtension.GetLoaderContext
        }
        
        /// <summary>
        /// Returns true if this extension is currently loaded. Must be called on the
        /// browser process UI thread.
        /// </summary>
        public int IsLoaded()
        {
            throw new NotImplementedException(); // TODO: CefExtension.IsLoaded
        }
        
        /// <summary>
        /// Unload this extension if it is not an internal extension and is currently
        /// loaded. Will result in a call to CefExtensionHandler::OnExtensionUnloaded
        /// on success.
        /// </summary>
        public void Unload()
        {
            throw new NotImplementedException(); // TODO: CefExtension.Unload
        }
        
    }
}
