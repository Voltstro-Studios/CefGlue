//------------------------------------------------------------------------------
// <auto-generated>
//      This file is auto-generated!
//      DO NOT MODIFY!
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Xilium.CefGlue.Interop;

namespace Xilium.CefGlue
{
    // Role: HANDLER
    #nullable enable
    public abstract unsafe partial class CefRenderProcessHandler
    {
        private static Dictionary<IntPtr, CefRenderProcessHandler> _roots = new Dictionary<IntPtr, CefRenderProcessHandler>();
        
        private int _refct;
        private cef_render_process_handler_t* _self;
        
        protected object SyncRoot { get { return this; } }
        
        private cef_render_process_handler_t.add_ref_delegate _ds0;
        private cef_render_process_handler_t.release_delegate _ds1;
        private cef_render_process_handler_t.has_one_ref_delegate _ds2;
        private cef_render_process_handler_t.has_at_least_one_ref_delegate _ds3;
        private cef_render_process_handler_t.on_web_kit_initialized_delegate _ds4;
        private cef_render_process_handler_t.on_browser_created_delegate _ds5;
        private cef_render_process_handler_t.on_browser_destroyed_delegate _ds6;
        private cef_render_process_handler_t.get_load_handler_delegate _ds7;
        private cef_render_process_handler_t.on_context_created_delegate _ds8;
        private cef_render_process_handler_t.on_context_released_delegate _ds9;
        private cef_render_process_handler_t.on_uncaught_exception_delegate _dsa;
        private cef_render_process_handler_t.on_focused_node_changed_delegate _dsb;
        private cef_render_process_handler_t.on_process_message_received_delegate _dsc;
        
        protected CefRenderProcessHandler()
        {
            _self = cef_render_process_handler_t.Alloc();
        
            _ds0 = new cef_render_process_handler_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_render_process_handler_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_render_process_handler_t.has_one_ref_delegate(has_one_ref);
            _self->_base._has_one_ref = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_render_process_handler_t.has_at_least_one_ref_delegate(has_at_least_one_ref);
            _self->_base._has_at_least_one_ref = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_render_process_handler_t.on_web_kit_initialized_delegate(on_web_kit_initialized);
            _self->_on_web_kit_initialized = Marshal.GetFunctionPointerForDelegate(_ds4);
            _ds5 = new cef_render_process_handler_t.on_browser_created_delegate(on_browser_created);
            _self->_on_browser_created = Marshal.GetFunctionPointerForDelegate(_ds5);
            _ds6 = new cef_render_process_handler_t.on_browser_destroyed_delegate(on_browser_destroyed);
            _self->_on_browser_destroyed = Marshal.GetFunctionPointerForDelegate(_ds6);
            _ds7 = new cef_render_process_handler_t.get_load_handler_delegate(get_load_handler);
            _self->_get_load_handler = Marshal.GetFunctionPointerForDelegate(_ds7);
            _ds8 = new cef_render_process_handler_t.on_context_created_delegate(on_context_created);
            _self->_on_context_created = Marshal.GetFunctionPointerForDelegate(_ds8);
            _ds9 = new cef_render_process_handler_t.on_context_released_delegate(on_context_released);
            _self->_on_context_released = Marshal.GetFunctionPointerForDelegate(_ds9);
            _dsa = new cef_render_process_handler_t.on_uncaught_exception_delegate(on_uncaught_exception);
            _self->_on_uncaught_exception = Marshal.GetFunctionPointerForDelegate(_dsa);
            _dsb = new cef_render_process_handler_t.on_focused_node_changed_delegate(on_focused_node_changed);
            _self->_on_focused_node_changed = Marshal.GetFunctionPointerForDelegate(_dsb);
            _dsc = new cef_render_process_handler_t.on_process_message_received_delegate(on_process_message_received);
            _self->_on_process_message_received = Marshal.GetFunctionPointerForDelegate(_dsc);
        }
        
        ~CefRenderProcessHandler()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_render_process_handler_t.Free(_self);
                _self = null;
            }
        }
        
        private void add_ref(cef_render_process_handler_t* self)
        {
            lock (SyncRoot)
            {
                var result = ++_refct;
                if (result == 1)
                {
                    lock (_roots) { _roots.Add((IntPtr)_self, this); }
                }
            }
        }
        
        private int release(cef_render_process_handler_t* self)
        {
            lock (SyncRoot)
            {
                var result = --_refct;
                if (result == 0)
                {
                    lock (_roots) { _roots.Remove((IntPtr)_self); }
                    return 1;
                }
                return 0;
            }
        }
        
        private int has_one_ref(cef_render_process_handler_t* self)
        {
            lock (SyncRoot) { return _refct == 1 ? 1 : 0; }
        }
        
        private int has_at_least_one_ref(cef_render_process_handler_t* self)
        {
            lock (SyncRoot) { return _refct != 0 ? 1 : 0; }
        }
        
        internal cef_render_process_handler_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_render_process_handler_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
