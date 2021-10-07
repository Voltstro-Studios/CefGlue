using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Xilium.CefGlue.Interop;

namespace Xilium.CefGlue
{
    /// <summary>
    /// Callback interface for asynchronous continuation of print job requests.
    /// </summary>
    public sealed unsafe partial class CefPrintJobCallback
    {
        /// <summary>
        /// Indicate completion of the print job.
        /// </summary>
        public void Continue()
        {
            throw new NotImplementedException(); // TODO: CefPrintJobCallback.Continue
        }
        
    }
}
