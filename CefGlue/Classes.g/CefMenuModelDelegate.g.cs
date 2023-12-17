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
    public abstract unsafe partial class CefMenuModelDelegate
    {
        private static Dictionary<IntPtr, CefMenuModelDelegate> _roots = new Dictionary<IntPtr, CefMenuModelDelegate>();
        
        private int _refct;
        private cef_menu_model_delegate_t* _self;
        
        protected object SyncRoot { get { return this; } }
        
        private cef_menu_model_delegate_t.add_ref_delegate _ds0;
        private cef_menu_model_delegate_t.release_delegate _ds1;
        private cef_menu_model_delegate_t.has_one_ref_delegate _ds2;
        private cef_menu_model_delegate_t.has_at_least_one_ref_delegate _ds3;
        private cef_menu_model_delegate_t.execute_command_delegate _ds4;
        private cef_menu_model_delegate_t.mouse_outside_menu_delegate _ds5;
        private cef_menu_model_delegate_t.unhandled_open_submenu_delegate _ds6;
        private cef_menu_model_delegate_t.unhandled_close_submenu_delegate _ds7;
        private cef_menu_model_delegate_t.menu_will_show_delegate _ds8;
        private cef_menu_model_delegate_t.menu_closed_delegate _ds9;
        private cef_menu_model_delegate_t.format_label_delegate _dsa;
        
        protected CefMenuModelDelegate()
        {
            _self = cef_menu_model_delegate_t.Alloc();
        
            _ds0 = new cef_menu_model_delegate_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_menu_model_delegate_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_menu_model_delegate_t.has_one_ref_delegate(has_one_ref);
            _self->_base._has_one_ref = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_menu_model_delegate_t.has_at_least_one_ref_delegate(has_at_least_one_ref);
            _self->_base._has_at_least_one_ref = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_menu_model_delegate_t.execute_command_delegate(execute_command);
            _self->_execute_command = Marshal.GetFunctionPointerForDelegate(_ds4);
            _ds5 = new cef_menu_model_delegate_t.mouse_outside_menu_delegate(mouse_outside_menu);
            _self->_mouse_outside_menu = Marshal.GetFunctionPointerForDelegate(_ds5);
            _ds6 = new cef_menu_model_delegate_t.unhandled_open_submenu_delegate(unhandled_open_submenu);
            _self->_unhandled_open_submenu = Marshal.GetFunctionPointerForDelegate(_ds6);
            _ds7 = new cef_menu_model_delegate_t.unhandled_close_submenu_delegate(unhandled_close_submenu);
            _self->_unhandled_close_submenu = Marshal.GetFunctionPointerForDelegate(_ds7);
            _ds8 = new cef_menu_model_delegate_t.menu_will_show_delegate(menu_will_show);
            _self->_menu_will_show = Marshal.GetFunctionPointerForDelegate(_ds8);
            _ds9 = new cef_menu_model_delegate_t.menu_closed_delegate(menu_closed);
            _self->_menu_closed = Marshal.GetFunctionPointerForDelegate(_ds9);
            _dsa = new cef_menu_model_delegate_t.format_label_delegate(format_label);
            _self->_format_label = Marshal.GetFunctionPointerForDelegate(_dsa);
        }
        
        ~CefMenuModelDelegate()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_menu_model_delegate_t.Free(_self);
                _self = null;
            }
        }
        
        private void add_ref(cef_menu_model_delegate_t* self)
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
        
        private int release(cef_menu_model_delegate_t* self)
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
        
        private int has_one_ref(cef_menu_model_delegate_t* self)
        {
            lock (SyncRoot) { return _refct == 1 ? 1 : 0; }
        }
        
        private int has_at_least_one_ref(cef_menu_model_delegate_t* self)
        {
            lock (SyncRoot) { return _refct != 0 ? 1 : 0; }
        }
        
        internal cef_menu_model_delegate_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_menu_model_delegate_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
