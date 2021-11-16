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
    public sealed unsafe partial class CefGetExtensionResourceCallback : IDisposable
    {
        internal static CefGetExtensionResourceCallback FromNative(cef_get_extension_resource_callback_t* ptr)
        {
            return new CefGetExtensionResourceCallback(ptr);
        }
        
        internal static CefGetExtensionResourceCallback FromNativeOrNull(cef_get_extension_resource_callback_t* ptr)
        {
            if (ptr == null) return null;
            return new CefGetExtensionResourceCallback(ptr);
        }
        
        private cef_get_extension_resource_callback_t* _self;
        
        private CefGetExtensionResourceCallback(cef_get_extension_resource_callback_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefGetExtensionResourceCallback()
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
            cef_get_extension_resource_callback_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_get_extension_resource_callback_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_get_extension_resource_callback_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_get_extension_resource_callback_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_get_extension_resource_callback_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
