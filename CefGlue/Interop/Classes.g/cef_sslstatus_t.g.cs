//------------------------------------------------------------------------------
// <auto-generated>
//      This file is auto-generated!
//      DO NOT MODIFY!
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security;

namespace Xilium.CefGlue.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_sslstatus_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _is_secure_connection;
        internal IntPtr _get_cert_status;
        internal IntPtr _get_sslversion;
        internal IntPtr _get_content_status;
        internal IntPtr _get_x509certificate;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void add_ref_delegate(cef_sslstatus_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_sslstatus_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_one_ref_delegate(cef_sslstatus_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_at_least_one_ref_delegate(cef_sslstatus_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_secure_connection_delegate(cef_sslstatus_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate CefCertStatus get_cert_status_delegate(cef_sslstatus_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate CefSslVersion get_sslversion_delegate(cef_sslstatus_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate CefSslContentStatus get_content_status_delegate(cef_sslstatus_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_x509certificate_t* get_x509certificate_delegate(cef_sslstatus_t* self);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static void add_ref(cef_sslstatus_t* self)
        {
            add_ref_delegate d;
            var p = self->_base._add_ref;
            if (p == _p0) { d = _d0; }
            else
            {
                d = (add_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_ref_delegate));
                if (_p0 == IntPtr.Zero) { _d0 = d; _p0 = p; }
            }
            d(self);
        }
        
        // Release
        private static IntPtr _p1;
        private static release_delegate _d1;
        
        public static int release(cef_sslstatus_t* self)
        {
            release_delegate d;
            var p = self->_base._release;
            if (p == _p1) { d = _d1; }
            else
            {
                d = (release_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(release_delegate));
                if (_p1 == IntPtr.Zero) { _d1 = d; _p1 = p; }
            }
            return d(self);
        }
        
        // HasOneRef
        private static IntPtr _p2;
        private static has_one_ref_delegate _d2;
        
        public static int has_one_ref(cef_sslstatus_t* self)
        {
            has_one_ref_delegate d;
            var p = self->_base._has_one_ref;
            if (p == _p2) { d = _d2; }
            else
            {
                d = (has_one_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_one_ref_delegate));
                if (_p2 == IntPtr.Zero) { _d2 = d; _p2 = p; }
            }
            return d(self);
        }
        
        // HasAtLeastOneRef
        private static IntPtr _p3;
        private static has_at_least_one_ref_delegate _d3;
        
        public static int has_at_least_one_ref(cef_sslstatus_t* self)
        {
            has_at_least_one_ref_delegate d;
            var p = self->_base._has_at_least_one_ref;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (has_at_least_one_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_at_least_one_ref_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self);
        }
        
        // IsSecureConnection
        private static IntPtr _p4;
        private static is_secure_connection_delegate _d4;
        
        public static int is_secure_connection(cef_sslstatus_t* self)
        {
            is_secure_connection_delegate d;
            var p = self->_is_secure_connection;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (is_secure_connection_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_secure_connection_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self);
        }
        
        // GetCertStatus
        private static IntPtr _p5;
        private static get_cert_status_delegate _d5;
        
        public static CefCertStatus get_cert_status(cef_sslstatus_t* self)
        {
            get_cert_status_delegate d;
            var p = self->_get_cert_status;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (get_cert_status_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_cert_status_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            return d(self);
        }
        
        // GetSSLVersion
        private static IntPtr _p6;
        private static get_sslversion_delegate _d6;
        
        public static CefSslVersion get_sslversion(cef_sslstatus_t* self)
        {
            get_sslversion_delegate d;
            var p = self->_get_sslversion;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (get_sslversion_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_sslversion_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            return d(self);
        }
        
        // GetContentStatus
        private static IntPtr _p7;
        private static get_content_status_delegate _d7;
        
        public static CefSslContentStatus get_content_status(cef_sslstatus_t* self)
        {
            get_content_status_delegate d;
            var p = self->_get_content_status;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (get_content_status_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_content_status_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            return d(self);
        }
        
        // GetX509Certificate
        private static IntPtr _p8;
        private static get_x509certificate_delegate _d8;
        
        public static cef_x509certificate_t* get_x509certificate(cef_sslstatus_t* self)
        {
            get_x509certificate_delegate d;
            var p = self->_get_x509certificate;
            if (p == _p8) { d = _d8; }
            else
            {
                d = (get_x509certificate_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_x509certificate_delegate));
                if (_p8 == IntPtr.Zero) { _d8 = d; _p8 = p; }
            }
            return d(self);
        }
        
    }
}
