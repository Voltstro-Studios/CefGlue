using Xilium.CefGlue.Interop;

namespace Xilium.CefGlue
{
    public abstract unsafe partial class CefFrameHandler
    {
        private void on_frame_created(cef_frame_handler_t* self, cef_browser_t* browser, cef_frame_t* frame)
        {
            CheckSelf(self);

            CefBrowser m_browser = CefBrowser.FromNative(browser);
            CefFrame m_frame = CefFrame.FromNative(frame);
            OnFrameCreated(m_browser, m_frame);
        }

        /// <summary>
        ///     Called when a new frame is created. This will be the first notification
        ///     that references |frame|. Any commands that require transport to the
        ///     associated renderer process (LoadRequest, SendProcessMessage, GetSource,
        ///     etc.) will be queued until OnFrameAttached is called for |frame|.
        /// </summary>
        protected virtual void OnFrameCreated(CefBrowser browser, CefFrame frame)
        {
        }

        private void on_frame_attached(cef_frame_handler_t* self, cef_browser_t* browser, cef_frame_t* frame)
        {
            CheckSelf(self);

            CefBrowser m_browser = CefBrowser.FromNative(browser);
            CefFrame m_frame = CefFrame.FromNative(frame);
            OnFrameAttached(m_browser, m_frame);
        }

        /// <summary>
        ///     Called when a frame can begin routing commands to/from the associated
        ///     renderer process. Any commands that were queued have now been dispatched.
        /// </summary>
        protected virtual void OnFrameAttached(CefBrowser browser, CefFrame frame)
        {
        }

        private void on_frame_detached(cef_frame_handler_t* self, cef_browser_t* browser, cef_frame_t* frame)
        {
            CheckSelf(self);

            CefBrowser m_browser = CefBrowser.FromNative(browser);
            CefFrame m_frame = CefFrame.FromNative(frame);
            OnFrameDetached(m_browser, m_frame);
        }

        /// <summary>
        ///     Called when a frame loses its connection to the renderer process and will
        ///     be destroyed. Any pending or future commands will be discarded and
        ///     CefFrame::IsValid() will now return false for |frame|. If called after
        ///     CefLifeSpanHandler::OnBeforeClose() during browser destruction then
        ///     CefBrowser::IsValid() will return false for |browser|.
        /// </summary>
        /// <param name="browser"></param>
        /// <param name="frame"></param>
        protected virtual void OnFrameDetached(CefBrowser browser, CefFrame frame)
        {
        }

        private void on_main_frame_changed(cef_frame_handler_t* self, cef_browser_t* browser, cef_frame_t* old_frame,
            cef_frame_t* new_frame)
        {
            CheckSelf(self);

            CefBrowser m_browser = CefBrowser.FromNative(browser);
            CefFrame m_oldFrame = CefFrame.FromNative(old_frame);
            CefFrame m_newFrame = CefFrame.FromNative(new_frame);
            OnMainFrameChanged(m_browser, m_oldFrame, m_newFrame);
        }

        /// <summary>
        ///     Called when the main frame changes due to (a) initial browser creation, (b)
        ///     final browser destruction, (c) cross-origin navigation or (d) re-navigation
        ///     after renderer process termination (due to crashes, etc). |old_frame| will
        ///     be NULL and |new_frame| will be non-NULL when a main frame is assigned to
        ///     |browser| for the first time. |old_frame| will be non-NULL and |new_frame|
        ///     will be NULL and  when a main frame is removed from |browser| for the last
        ///     time. Both |old_frame| and |new_frame| will be non-NULL for cross-origin
        ///     navigations or re-navigation after renderer process termination. This
        ///     method will be called after OnFrameCreated() for |new_frame| and/or after
        ///     OnFrameDetached() for |old_frame|. If called after
        ///     CefLifeSpanHandler::OnBeforeClose() during browser destruction then
        ///     CefBrowser::IsValid() will return false for |browser|.
        /// </summary>
        /// <param name="browser"></param>
        /// <param name="oldFrame"></param>
        /// <param name="newFrame"></param>
        protected virtual void OnMainFrameChanged(CefBrowser browser, CefFrame oldFrame, CefFrame newFrame)
        {
        }
    }
}
