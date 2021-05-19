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
    public sealed unsafe partial class CefBrowserHost : IDisposable
    {
        internal static CefBrowserHost FromNative(cef_browser_host_t* ptr)
        {
            return new CefBrowserHost(ptr);
        }
        
        internal static CefBrowserHost FromNativeOrNull(cef_browser_host_t* ptr)
        {
            if (ptr == null) return null;
            return new CefBrowserHost(ptr);
        }
        
        private cef_browser_host_t* _self;
        
        private CefBrowserHost(cef_browser_host_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefBrowserHost()
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
            cef_browser_host_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_browser_host_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_browser_host_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_browser_host_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_browser_host_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
