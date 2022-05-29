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
    internal unsafe struct cef_run_file_dialog_callback_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _on_file_dialog_dismissed;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_run_file_dialog_callback_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_run_file_dialog_callback_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_one_ref_delegate(cef_run_file_dialog_callback_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_at_least_one_ref_delegate(cef_run_file_dialog_callback_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_file_dialog_dismissed_delegate(cef_run_file_dialog_callback_t* self, cef_string_list* file_paths);
        
        private static int _sizeof;
        
        static cef_run_file_dialog_callback_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_run_file_dialog_callback_t));
        }
        
        internal static cef_run_file_dialog_callback_t* Alloc()
        {
            var ptr = (cef_run_file_dialog_callback_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_run_file_dialog_callback_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_run_file_dialog_callback_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
