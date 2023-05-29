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
    public sealed unsafe partial class CefBrowser : IDisposable
    {
        internal static CefBrowser FromNative(cef_browser_t* ptr)
        {
            return new CefBrowser(ptr);
        }
        
        internal static CefBrowser? FromNativeOrNull(cef_browser_t* ptr)
        {
            if (ptr == null) return null;
            return new CefBrowser(ptr);
        }
        
        private cef_browser_t* _self;
        private int _disposed = 0;
        
        private CefBrowser(cef_browser_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
            CefObjectTracker.Track(this);
        }
        
        ~CefBrowser()
        {
            if (Interlocked.CompareExchange(ref _disposed, 1, 0) == 0)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (Interlocked.CompareExchange(ref _disposed, 1, 0) == 0)
            {
                Release();
                _self = null;
            }
            CefObjectTracker.Untrack(this);
            GC.SuppressFinalize(this);
        }
        
        internal void AddRef()
        {
            cef_browser_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_browser_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_browser_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_browser_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_browser_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
