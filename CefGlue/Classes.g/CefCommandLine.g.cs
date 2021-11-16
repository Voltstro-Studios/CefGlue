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
    public sealed unsafe partial class CefCommandLine : IDisposable
    {
        internal static CefCommandLine FromNative(cef_command_line_t* ptr)
        {
            return new CefCommandLine(ptr);
        }
        
        internal static CefCommandLine FromNativeOrNull(cef_command_line_t* ptr)
        {
            if (ptr == null) return null;
            return new CefCommandLine(ptr);
        }
        
        private cef_command_line_t* _self;
        
        private CefCommandLine(cef_command_line_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefCommandLine()
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
            cef_command_line_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_command_line_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_command_line_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_command_line_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_command_line_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
