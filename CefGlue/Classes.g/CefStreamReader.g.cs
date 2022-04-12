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
    public sealed unsafe partial class CefStreamReader : IDisposable
    {
        internal static CefStreamReader FromNative(cef_stream_reader_t* ptr)
        {
            return new CefStreamReader(ptr);
        }
        
        internal static CefStreamReader? FromNativeOrNull(cef_stream_reader_t* ptr)
        {
            if (ptr == null) return null;
            return new CefStreamReader(ptr);
        }
        
        private cef_stream_reader_t* _self;
        
        private CefStreamReader(cef_stream_reader_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefStreamReader()
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
            cef_stream_reader_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_stream_reader_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_stream_reader_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_stream_reader_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_stream_reader_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
