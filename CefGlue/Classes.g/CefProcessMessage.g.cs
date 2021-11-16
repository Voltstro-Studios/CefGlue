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
    public sealed unsafe partial class CefProcessMessage : IDisposable
    {
        internal static CefProcessMessage FromNative(cef_process_message_t* ptr)
        {
            return new CefProcessMessage(ptr);
        }
        
        internal static CefProcessMessage FromNativeOrNull(cef_process_message_t* ptr)
        {
            if (ptr == null) return null;
            return new CefProcessMessage(ptr);
        }
        
        private cef_process_message_t* _self;
        
        private CefProcessMessage(cef_process_message_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefProcessMessage()
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
            cef_process_message_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_process_message_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_process_message_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_process_message_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_process_message_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
