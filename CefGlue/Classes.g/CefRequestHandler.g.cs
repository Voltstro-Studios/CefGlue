//------------------------------------------------------------------------------
// <auto-generated>
//      This file is auto-generated!
//      DO NOT MODIFY!
// </auto-generated>
//------------------------------------------------------------------------------
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Threading;
    using Xilium.CefGlue.Interop;
    
    // Role: HANDLER
    #nullable enable
    public abstract unsafe partial class CefRequestHandler
    {
        private static Dictionary<IntPtr, CefRequestHandler> _roots = new Dictionary<IntPtr, CefRequestHandler>();
        
        private int _refct;
        private cef_request_handler_t* _self;
        
        private cef_request_handler_t.add_ref_delegate _ds0;
        private cef_request_handler_t.release_delegate _ds1;
        private cef_request_handler_t.has_one_ref_delegate _ds2;
        private cef_request_handler_t.has_at_least_one_ref_delegate _ds3;
        private cef_request_handler_t.on_before_browse_delegate _ds4;
        private cef_request_handler_t.on_open_urlfrom_tab_delegate _ds5;
        private cef_request_handler_t.get_resource_request_handler_delegate _ds6;
        private cef_request_handler_t.get_auth_credentials_delegate _ds7;
        private cef_request_handler_t.on_certificate_error_delegate _ds8;
        private cef_request_handler_t.on_select_client_certificate_delegate _ds9;
        private cef_request_handler_t.on_render_view_ready_delegate _dsa;
        private cef_request_handler_t.on_render_process_terminated_delegate _dsb;
        private cef_request_handler_t.on_document_available_in_main_frame_delegate _dsc;
        
        protected CefRequestHandler()
        {
            _self = cef_request_handler_t.Alloc();
        
            _ds0 = new cef_request_handler_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_request_handler_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_request_handler_t.has_one_ref_delegate(has_one_ref);
            _self->_base._has_one_ref = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_request_handler_t.has_at_least_one_ref_delegate(has_at_least_one_ref);
            _self->_base._has_at_least_one_ref = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_request_handler_t.on_before_browse_delegate(on_before_browse);
            _self->_on_before_browse = Marshal.GetFunctionPointerForDelegate(_ds4);
            _ds5 = new cef_request_handler_t.on_open_urlfrom_tab_delegate(on_open_urlfrom_tab);
            _self->_on_open_urlfrom_tab = Marshal.GetFunctionPointerForDelegate(_ds5);
            _ds6 = new cef_request_handler_t.get_resource_request_handler_delegate(get_resource_request_handler);
            _self->_get_resource_request_handler = Marshal.GetFunctionPointerForDelegate(_ds6);
            _ds7 = new cef_request_handler_t.get_auth_credentials_delegate(get_auth_credentials);
            _self->_get_auth_credentials = Marshal.GetFunctionPointerForDelegate(_ds7);
            _ds8 = new cef_request_handler_t.on_certificate_error_delegate(on_certificate_error);
            _self->_on_certificate_error = Marshal.GetFunctionPointerForDelegate(_ds8);
            _ds9 = new cef_request_handler_t.on_select_client_certificate_delegate(on_select_client_certificate);
            _self->_on_select_client_certificate = Marshal.GetFunctionPointerForDelegate(_ds9);
            _dsa = new cef_request_handler_t.on_render_view_ready_delegate(on_render_view_ready);
            _self->_on_render_view_ready = Marshal.GetFunctionPointerForDelegate(_dsa);
            _dsb = new cef_request_handler_t.on_render_process_terminated_delegate(on_render_process_terminated);
            _self->_on_render_process_terminated = Marshal.GetFunctionPointerForDelegate(_dsb);
            _dsc = new cef_request_handler_t.on_document_available_in_main_frame_delegate(on_document_available_in_main_frame);
            _self->_on_document_available_in_main_frame = Marshal.GetFunctionPointerForDelegate(_dsc);
        }
        
        ~CefRequestHandler()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_request_handler_t.Free(_self);
                _self = null;
            }
        }
        
        private void add_ref(cef_request_handler_t* self)
        {
            if (Interlocked.Increment(ref _refct) == 1)
            {
                lock (_roots) { _roots.Add((IntPtr)_self, this); }
            }
        }
        
        private int release(cef_request_handler_t* self)
        {
            if (Interlocked.Decrement(ref _refct) == 0)
            {
                lock (_roots) { _roots.Remove((IntPtr)_self); }
                return 1;
            }
            return 0;
        }
        
        private int has_one_ref(cef_request_handler_t* self)
        {
            return _refct == 1 ? 1 : 0;
        }
        
        private int has_at_least_one_ref(cef_request_handler_t* self)
        {
            return _refct != 0 ? 1 : 0;
        }
        
        internal cef_request_handler_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_request_handler_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
