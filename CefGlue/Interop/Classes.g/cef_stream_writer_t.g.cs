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
    internal unsafe struct cef_stream_writer_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _write;
        internal IntPtr _seek;
        internal IntPtr _tell;
        internal IntPtr _flush;
        internal IntPtr _may_block;
        
        // CreateForFile
        [DllImport(libcef.DllName, EntryPoint = "cef_stream_writer_create_for_file", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_stream_writer_t* create_for_file(cef_string_t* fileName);
        
        // CreateForHandler
        [DllImport(libcef.DllName, EntryPoint = "cef_stream_writer_create_for_handler", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_stream_writer_t* create_for_handler(cef_write_handler_t* handler);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void add_ref_delegate(cef_stream_writer_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_stream_writer_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_one_ref_delegate(cef_stream_writer_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_at_least_one_ref_delegate(cef_stream_writer_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate UIntPtr write_delegate(cef_stream_writer_t* self, void* ptr, UIntPtr size, UIntPtr n);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int seek_delegate(cef_stream_writer_t* self, long offset, int whence);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate long tell_delegate(cef_stream_writer_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int flush_delegate(cef_stream_writer_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int may_block_delegate(cef_stream_writer_t* self);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static void add_ref(cef_stream_writer_t* self)
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
        
        public static int release(cef_stream_writer_t* self)
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
        
        public static int has_one_ref(cef_stream_writer_t* self)
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
        
        public static int has_at_least_one_ref(cef_stream_writer_t* self)
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
        
        // Write
        private static IntPtr _p4;
        private static write_delegate _d4;
        
        public static UIntPtr write(cef_stream_writer_t* self, void* ptr, UIntPtr size, UIntPtr n)
        {
            write_delegate d;
            var p = self->_write;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (write_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(write_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self, ptr, size, n);
        }
        
        // Seek
        private static IntPtr _p5;
        private static seek_delegate _d5;
        
        public static int seek(cef_stream_writer_t* self, long offset, int whence)
        {
            seek_delegate d;
            var p = self->_seek;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (seek_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(seek_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            return d(self, offset, whence);
        }
        
        // Tell
        private static IntPtr _p6;
        private static tell_delegate _d6;
        
        public static long tell(cef_stream_writer_t* self)
        {
            tell_delegate d;
            var p = self->_tell;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (tell_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(tell_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            return d(self);
        }
        
        // Flush
        private static IntPtr _p7;
        private static flush_delegate _d7;
        
        public static int flush(cef_stream_writer_t* self)
        {
            flush_delegate d;
            var p = self->_flush;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (flush_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(flush_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            return d(self);
        }
        
        // MayBlock
        private static IntPtr _p8;
        private static may_block_delegate _d8;
        
        public static int may_block(cef_stream_writer_t* self)
        {
            may_block_delegate d;
            var p = self->_may_block;
            if (p == _p8) { d = _d8; }
            else
            {
                d = (may_block_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(may_block_delegate));
                if (_p8 == IntPtr.Zero) { _d8 = d; _p8 = p; }
            }
            return d(self);
        }
        
    }
}
