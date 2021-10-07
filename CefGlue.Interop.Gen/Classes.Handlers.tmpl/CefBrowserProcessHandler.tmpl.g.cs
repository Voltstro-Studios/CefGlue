using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Xilium.CefGlue.Interop;

namespace Xilium.CefGlue
{
    /// <summary>
    /// Class used to implement browser process callbacks. The methods of this class
    /// will be called on the browser process main thread unless otherwise indicated.
    /// </summary>
    public abstract unsafe partial class CefBrowserProcessHandler
    {
        private void on_context_initialized(cef_browser_process_handler_t* self)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefBrowserProcessHandler.OnContextInitialized
        }
        
        /// <summary>
        /// Called on the browser process UI thread immediately after the CEF context
        /// has been initialized.
        /// </summary>
        // protected abstract void OnContextInitialized();
        
        private void on_before_child_process_launch(cef_browser_process_handler_t* self, cef_command_line_t* command_line)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefBrowserProcessHandler.OnBeforeChildProcessLaunch
        }
        
        /// <summary>
        /// Called before a child process is launched. Will be called on the browser
        /// process UI thread when launching a render process and on the browser
        /// process IO thread when launching a GPU or plugin process. Provides an
        /// opportunity to modify the child process command line. Do not keep a
        /// reference to |command_line| outside of this method.
        /// </summary>
        // protected abstract void OnBeforeChildProcessLaunch(cef_command_line_t* command_line);
        
        private void on_schedule_message_pump_work(cef_browser_process_handler_t* self, long delay_ms)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefBrowserProcessHandler.OnScheduleMessagePumpWork
        }
        
        /// <summary>
        /// Called from any thread when work has been scheduled for the browser process
        /// main (UI) thread. This callback is used in combination with CefSettings.
        /// external_message_pump and CefDoMessageLoopWork() in cases where the CEF
        /// message loop must be integrated into an existing application message loop
        /// (see additional comments and warnings on CefDoMessageLoopWork). This
        /// callback should schedule a CefDoMessageLoopWork() call to happen on the
        /// main (UI) thread. |delay_ms| is the requested delay in milliseconds. If
        /// |delay_ms| is <= 0 then the call should happen reasonably soon. If
        /// |delay_ms| is > 0 then the call should be scheduled to happen after the
        /// specified delay and any currently pending scheduled call should be
        /// cancelled.
        /// </summary>
        // protected abstract void OnScheduleMessagePumpWork(long delay_ms);
        
        private cef_client_t* get_default_client(cef_browser_process_handler_t* self)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefBrowserProcessHandler.GetDefaultClient
        }
        
        /// <summary>
        /// Return the default client for use with a newly created browser window. If
        /// null is returned the browser will be unmanaged (no callbacks will be
        /// executed for that browser) and application shutdown will be blocked until
        /// the browser window is closed manually. This method is currently only used
        /// with the chrome runtime.
        /// </summary>
        // protected abstract cef_client_t* GetDefaultClient();
        
    }
}
