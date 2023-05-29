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
    
    // Role: HANDLER
    #nullable enable
    public abstract unsafe partial class CefSchemeHandlerFactory
    {
        private static Dictionary<IntPtr, CefSchemeHandlerFactory> _roots = new Dictionary<IntPtr, CefSchemeHandlerFactory>();
        
        private int _refct;
        private cef_scheme_handler_factory_t* _self;
        
        private cef_scheme_handler_factory_t.add_ref_delegate _ds0;
        private cef_scheme_handler_factory_t.release_delegate _ds1;
        private cef_scheme_handler_factory_t.has_one_ref_delegate _ds2;
        private cef_scheme_handler_factory_t.has_at_least_one_ref_delegate _ds3;
        private cef_scheme_handler_factory_t.create_delegate _ds4;
        
        protected CefSchemeHandlerFactory()
        {
            _self = cef_scheme_handler_factory_t.Alloc();
        
            _ds0 = new cef_scheme_handler_factory_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_scheme_handler_factory_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_scheme_handler_factory_t.has_one_ref_delegate(has_one_ref);
            _self->_base._has_one_ref = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_scheme_handler_factory_t.has_at_least_one_ref_delegate(has_at_least_one_ref);
            _self->_base._has_at_least_one_ref = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_scheme_handler_factory_t.create_delegate(create);
            _self->_create = Marshal.GetFunctionPointerForDelegate(_ds4);
        }
        
        ~CefSchemeHandlerFactory()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_scheme_handler_factory_t.Free(_self);
                _self = null;
            }
        }
        
        private void add_ref(cef_scheme_handler_factory_t* self)
        {
            if (Interlocked.Increment(ref _refct) == 1)
            {
                lock (_roots) { _roots.Add((IntPtr)_self, this); }
            }
        }
        
        private int release(cef_scheme_handler_factory_t* self)
        {
            if (Interlocked.Decrement(ref _refct) == 0)
            {
                lock (_roots) { _roots.Remove((IntPtr)_self); }
                return 1;
            }
            return 0;
        }
        
        private int has_one_ref(cef_scheme_handler_factory_t* self)
        {
            return _refct == 1 ? 1 : 0;
        }
        
        private int has_at_least_one_ref(cef_scheme_handler_factory_t* self)
        {
            return _refct != 0 ? 1 : 0;
        }
        
        internal cef_scheme_handler_factory_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_scheme_handler_factory_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
