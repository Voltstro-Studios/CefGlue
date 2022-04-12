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
    #nullable enable
    public sealed unsafe partial class CefV8Context : IDisposable
    {
        internal static CefV8Context FromNative(cef_v8context_t* ptr)
        {
            return new CefV8Context(ptr);
        }
        
        internal static CefV8Context? FromNativeOrNull(cef_v8context_t* ptr)
        {
            if (ptr == null) return null;
            return new CefV8Context(ptr);
        }
        
        private cef_v8context_t* _self;
        
        private CefV8Context(cef_v8context_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefV8Context()
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
            cef_v8context_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_v8context_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_v8context_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_v8context_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_v8context_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
