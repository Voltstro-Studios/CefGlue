using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Xilium.CefGlue.Interop;

namespace Xilium.CefGlue
{
    /// <summary>
    /// Callback interface used for asynchronous continuation of
    /// CefExtensionHandler::GetExtensionResource.
    /// </summary>
    public sealed unsafe partial class CefGetExtensionResourceCallback
    {
        /// <summary>
        /// Continue the request. Read the resource contents from |stream|.
        /// </summary>
        public void Continue(cef_stream_reader_t* stream)
        {
            throw new NotImplementedException(); // TODO: CefGetExtensionResourceCallback.Continue
        }
        
        /// <summary>
        /// Cancel the request.
        /// </summary>
        public void Cancel()
        {
            throw new NotImplementedException(); // TODO: CefGetExtensionResourceCallback.Cancel
        }
        
    }
}
