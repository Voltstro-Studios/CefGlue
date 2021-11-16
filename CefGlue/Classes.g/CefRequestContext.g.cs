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
    public sealed unsafe partial class CefRequestContext : IDisposable
    {
        internal static CefRequestContext FromNative(cef_request_context_t* ptr)
        {
            return new CefRequestContext(ptr);
        }
        
        internal static CefRequestContext FromNativeOrNull(cef_request_context_t* ptr)
        {
            if (ptr == null) return null;
            return new CefRequestContext(ptr);
        }
        
        private cef_request_context_t* _self;
        
        private CefRequestContext(cef_request_context_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefRequestContext()
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
            cef_request_context_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_request_context_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_request_context_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_request_context_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_request_context_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
