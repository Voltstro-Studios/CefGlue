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
    
    // Role: PROXY
    #nullable enable
    public sealed unsafe partial class CefBinaryValue : IDisposable
    {
        internal static CefBinaryValue FromNative(cef_binary_value_t* ptr)
        {
            return new CefBinaryValue(ptr);
        }
        
        internal static CefBinaryValue FromNativeOrNull(cef_binary_value_t* ptr)
        {
            if (ptr == null) return null;
            return new CefBinaryValue(ptr);
        }
        
        private cef_binary_value_t* _self;
        
        private CefBinaryValue(cef_binary_value_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefBinaryValue()
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
            cef_binary_value_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_binary_value_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_binary_value_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_binary_value_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_binary_value_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
