﻿using Xilium.CefGlue.Interop;

namespace Xilium.CefGlue;

/// <summary>
///     Interface that should be implemented to handle V8 function calls. The methods
///     of this class will be called on the thread associated with the V8 function.
/// </summary>
public abstract unsafe partial class CefV8Accessor
{
    private int get(cef_v8_accessor_t* self, cef_string_t* name, cef_v8_value_t* @object, cef_v8_value_t** retval,
        cef_string_t* exception)
    {
        CheckSelf(self);

        var m_name = cef_string_t.ToString(name);
        var m_obj = CefV8Value.FromNative(@object);

        var handled = Get(m_name, m_obj, out var m_returnValue, out var mException);

        if (handled)
        {
            if (mException != null)
                cef_string_t.Copy(mException, exception);
            else if (m_returnValue != null) *retval = m_returnValue.ToNative();
        }

        return handled ? 1 : 0;
    }

    /// <summary>
    ///     Handle retrieval the accessor value identified by |name|. |object| is the
    ///     receiver ('this' object) of the accessor. If retrieval succeeds set
    ///     |retval| to the return value. If retrieval fails set |exception| to the
    ///     exception that will be thrown. Return true if accessor retrieval was
    ///     handled.
    /// </summary>
    protected abstract bool Get(string? name, CefV8Value obj, out CefV8Value? returnValue, out string? exception);


    private int set(cef_v8_accessor_t* self, cef_string_t* name, cef_v8_value_t* @object, cef_v8_value_t* value,
        cef_string_t* exception)
    {
        CheckSelf(self);

        var m_name = cef_string_t.ToString(name);
        var m_obj = CefV8Value.FromNative(@object);
        var m_value = CefV8Value.FromNative(value);

        var handled = Set(m_name, m_obj, m_value, out var mException);

        if (handled)
            if (mException != null)
                cef_string_t.Copy(mException, exception);

        return handled ? 1 : 0;
    }

    /// <summary>
    ///     Handle assignment of the accessor value identified by |name|. |object| is
    ///     the receiver ('this' object) of the accessor. |value| is the new value
    ///     being assigned to the accessor. If assignment fails set |exception| to the
    ///     exception that will be thrown. Return true if accessor assignment was
    ///     handled.
    /// </summary>
    protected abstract bool Set(string? name, CefV8Value obj, CefV8Value? value, out string? exception);
}