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
    // Role: PROXY
    public sealed unsafe partial class CefRunContextMenuCallback : IDisposable
    {
        internal static CefRunContextMenuCallback FromNative(cef_run_context_menu_callback_t* ptr)
        {
            return new CefRunContextMenuCallback(ptr);
        }
        
        internal static CefRunContextMenuCallback FromNativeOrNull(cef_run_context_menu_callback_t* ptr)
        {
            if (ptr == null) return null;
            return new CefRunContextMenuCallback(ptr);
        }
        
        private cef_run_context_menu_callback_t* _self;
        
        private CefRunContextMenuCallback(cef_run_context_menu_callback_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefRunContextMenuCallback()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
            GC.SuppressFinalize(this);
        }
        
        internal void AddRef()
        {
            cef_run_context_menu_callback_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_run_context_menu_callback_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_run_context_menu_callback_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_run_context_menu_callback_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_run_context_menu_callback_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
