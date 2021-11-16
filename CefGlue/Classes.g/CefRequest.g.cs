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
    public sealed unsafe partial class CefRequest : IDisposable
    {
        internal static CefRequest FromNative(cef_request_t* ptr)
        {
            return new CefRequest(ptr);
        }
        
        internal static CefRequest FromNativeOrNull(cef_request_t* ptr)
        {
            if (ptr == null) return null;
            return new CefRequest(ptr);
        }
        
        private cef_request_t* _self;
        
        private CefRequest(cef_request_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefRequest()
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
            cef_request_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_request_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_request_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_request_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_request_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
