using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Xilium.CefGlue.Interop;

namespace Xilium.CefGlue
{
    /// <summary>
    /// Class used for retrieving resources from the resource bundle (*.pak) files
    /// loaded by CEF during startup or via the CefResourceBundleHandler returned
    /// from CefApp::GetResourceBundleHandler. See CefSettings for additional options
    /// related to resource bundle loading. The methods of this class may be called
    /// on any thread unless otherwise indicated.
    /// </summary>
    public sealed unsafe partial class CefResourceBundle
    {
        /// <summary>
        /// Returns the global resource bundle instance.
        /// </summary>
        public static cef_resource_bundle_t* GetGlobal()
        {
            throw new NotImplementedException(); // TODO: CefResourceBundle.GetGlobal
        }
        
        /// <summary>
        /// Returns the localized string for the specified |string_id| or an empty
        /// string if the value is not found. Include cef_pack_strings.h for a listing
        /// of valid string ID values.
        /// </summary>
        public cef_string_userfree* GetLocalizedString(int string_id)
        {
            throw new NotImplementedException(); // TODO: CefResourceBundle.GetLocalizedString
        }
        
        /// <summary>
        /// Returns a CefBinaryValue containing the decompressed contents of the
        /// specified scale independent |resource_id| or NULL if not found. Include
        /// cef_pack_resources.h for a listing of valid resource ID values.
        /// </summary>
        public cef_binary_value_t* GetDataResource(int resource_id)
        {
            throw new NotImplementedException(); // TODO: CefResourceBundle.GetDataResource
        }
        
        /// <summary>
        /// Returns a CefBinaryValue containing the decompressed contents of the
        /// specified |resource_id| nearest the scale factor |scale_factor| or NULL if
        /// not found. Use a |scale_factor| value of SCALE_FACTOR_NONE for scale
        /// independent resources or call GetDataResource instead.Include
        /// cef_pack_resources.h for a listing of valid resource ID values.
        /// </summary>
        public cef_binary_value_t* GetDataResourceForScale(int resource_id, CefScaleFactor scale_factor)
        {
            throw new NotImplementedException(); // TODO: CefResourceBundle.GetDataResourceForScale
        }
        
    }
}
