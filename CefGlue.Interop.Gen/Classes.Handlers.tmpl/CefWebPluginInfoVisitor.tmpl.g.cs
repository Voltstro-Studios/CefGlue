using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Xilium.CefGlue.Interop;

namespace Xilium.CefGlue
{
    /// <summary>
    /// Interface to implement for visiting web plugin information. The methods of
    /// this class will be called on the browser process UI thread.
    /// </summary>
    public abstract unsafe partial class CefWebPluginInfoVisitor
    {
        private int visit(cef_web_plugin_info_visitor_t* self, cef_web_plugin_info_t* info, int count, int total)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefWebPluginInfoVisitor.Visit
        }
        
        /// <summary>
        /// Method that will be called once for each plugin. |count| is the 0-based
        /// index for the current plugin. |total| is the total number of plugins.
        /// Return false to stop visiting plugins. This method may never be called if
        /// no plugins are found.
        /// </summary>
        // protected abstract int Visit(cef_web_plugin_info_t* info, int count, int total);
        
    }
}
