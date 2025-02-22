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
    public sealed unsafe partial class CefV8StackTrace : IDisposable
    {
        internal static CefV8StackTrace FromNative(cef_v8_stack_trace_t* ptr)
        {
            return new CefV8StackTrace(ptr);
        }
        
        internal static CefV8StackTrace FromNativeOrNull(cef_v8_stack_trace_t* ptr)
        {
            if (ptr == null) return null;
            return new CefV8StackTrace(ptr);
        }
        
        private cef_v8_stack_trace_t* _self;
        
        private CefV8StackTrace(cef_v8_stack_trace_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefV8StackTrace()
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
            cef_v8_stack_trace_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_v8_stack_trace_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_v8_stack_trace_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_v8_stack_trace_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_v8_stack_trace_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
