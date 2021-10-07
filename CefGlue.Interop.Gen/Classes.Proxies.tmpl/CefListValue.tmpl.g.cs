using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Xilium.CefGlue.Interop;

namespace Xilium.CefGlue
{
    /// <summary>
    /// Class representing a list value. Can be used on any process and thread.
    /// </summary>
    public sealed unsafe partial class CefListValue
    {
        /// <summary>
        /// Creates a new object that is not owned by any other object.
        /// </summary>
        public static cef_list_value_t* Create()
        {
            throw new NotImplementedException(); // TODO: CefListValue.Create
        }
        
        /// <summary>
        /// Returns true if this object is valid. This object may become invalid if
        /// the underlying data is owned by another object (e.g. list or dictionary)
        /// and that other object is then modified or destroyed. Do not call any other
        /// methods if this method returns false.
        /// </summary>
        public int IsValid()
        {
            throw new NotImplementedException(); // TODO: CefListValue.IsValid
        }
        
        /// <summary>
        /// Returns true if this object is currently owned by another object.
        /// </summary>
        public int IsOwned()
        {
            throw new NotImplementedException(); // TODO: CefListValue.IsOwned
        }
        
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// </summary>
        public int IsReadOnly()
        {
            throw new NotImplementedException(); // TODO: CefListValue.IsReadOnly
        }
        
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data. If true modifications to this object will also affect |that| object
        /// and vice-versa.
        /// </summary>
        public int IsSame(cef_list_value_t* that)
        {
            throw new NotImplementedException(); // TODO: CefListValue.IsSame
        }
        
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// </summary>
        public int IsEqual(cef_list_value_t* that)
        {
            throw new NotImplementedException(); // TODO: CefListValue.IsEqual
        }
        
        /// <summary>
        /// Returns a writable copy of this object.
        /// </summary>
        public cef_list_value_t* Copy()
        {
            throw new NotImplementedException(); // TODO: CefListValue.Copy
        }
        
        /// <summary>
        /// Sets the number of values. If the number of values is expanded all
        /// new value slots will default to type null. Returns true on success.
        /// </summary>
        public int SetSize(UIntPtr size)
        {
            throw new NotImplementedException(); // TODO: CefListValue.SetSize
        }
        
        /// <summary>
        /// Returns the number of values.
        /// </summary>
        public UIntPtr GetSize()
        {
            throw new NotImplementedException(); // TODO: CefListValue.GetSize
        }
        
        /// <summary>
        /// Removes all values. Returns true on success.
        /// </summary>
        public int Clear()
        {
            throw new NotImplementedException(); // TODO: CefListValue.Clear
        }
        
        /// <summary>
        /// Removes the value at the specified index.
        /// </summary>
        public int Remove(UIntPtr index)
        {
            throw new NotImplementedException(); // TODO: CefListValue.Remove
        }
        
        /// <summary>
        /// Returns the value type at the specified index.
        /// </summary>
        public CefValueType GetType(UIntPtr index)
        {
            throw new NotImplementedException(); // TODO: CefListValue.GetType
        }
        
        /// <summary>
        /// Returns the value at the specified index. For simple types the returned
        /// value will copy existing data and modifications to the value will not
        /// modify this object. For complex types (binary, dictionary and list) the
        /// returned value will reference existing data and modifications to the value
        /// will modify this object.
        /// </summary>
        public cef_value_t* GetValue(UIntPtr index)
        {
            throw new NotImplementedException(); // TODO: CefListValue.GetValue
        }
        
        /// <summary>
        /// Returns the value at the specified index as type bool.
        /// </summary>
        public int GetBool(UIntPtr index)
        {
            throw new NotImplementedException(); // TODO: CefListValue.GetBool
        }
        
        /// <summary>
        /// Returns the value at the specified index as type int.
        /// </summary>
        public int GetInt(UIntPtr index)
        {
            throw new NotImplementedException(); // TODO: CefListValue.GetInt
        }
        
        /// <summary>
        /// Returns the value at the specified index as type double.
        /// </summary>
        public double GetDouble(UIntPtr index)
        {
            throw new NotImplementedException(); // TODO: CefListValue.GetDouble
        }
        
        /// <summary>
        /// Returns the value at the specified index as type string.
        /// </summary>
        public cef_string_userfree* GetString(UIntPtr index)
        {
            throw new NotImplementedException(); // TODO: CefListValue.GetString
        }
        
        /// <summary>
        /// Returns the value at the specified index as type binary. The returned
        /// value will reference existing data.
        /// </summary>
        public cef_binary_value_t* GetBinary(UIntPtr index)
        {
            throw new NotImplementedException(); // TODO: CefListValue.GetBinary
        }
        
        /// <summary>
        /// Returns the value at the specified index as type dictionary. The returned
        /// value will reference existing data and modifications to the value will
        /// modify this object.
        /// </summary>
        public cef_dictionary_value_t* GetDictionary(UIntPtr index)
        {
            throw new NotImplementedException(); // TODO: CefListValue.GetDictionary
        }
        
        /// <summary>
        /// Returns the value at the specified index as type list. The returned
        /// value will reference existing data and modifications to the value will
        /// modify this object.
        /// </summary>
        public cef_list_value_t* GetList(UIntPtr index)
        {
            throw new NotImplementedException(); // TODO: CefListValue.GetList
        }
        
        /// <summary>
        /// Sets the value at the specified index. Returns true if the value was set
        /// successfully. If |value| represents simple data then the underlying data
        /// will be copied and modifications to |value| will not modify this object. If
        /// |value| represents complex data (binary, dictionary or list) then the
        /// underlying data will be referenced and modifications to |value| will modify
        /// this object.
        /// </summary>
        public int SetValue(UIntPtr index, cef_value_t* value)
        {
            throw new NotImplementedException(); // TODO: CefListValue.SetValue
        }
        
        /// <summary>
        /// Sets the value at the specified index as type null. Returns true if the
        /// value was set successfully.
        /// </summary>
        public int SetNull(UIntPtr index)
        {
            throw new NotImplementedException(); // TODO: CefListValue.SetNull
        }
        
        /// <summary>
        /// Sets the value at the specified index as type bool. Returns true if the
        /// value was set successfully.
        /// </summary>
        public int SetBool(UIntPtr index, int value)
        {
            throw new NotImplementedException(); // TODO: CefListValue.SetBool
        }
        
        /// <summary>
        /// Sets the value at the specified index as type int. Returns true if the
        /// value was set successfully.
        /// </summary>
        public int SetInt(UIntPtr index, int value)
        {
            throw new NotImplementedException(); // TODO: CefListValue.SetInt
        }
        
        /// <summary>
        /// Sets the value at the specified index as type double. Returns true if the
        /// value was set successfully.
        /// </summary>
        public int SetDouble(UIntPtr index, double value)
        {
            throw new NotImplementedException(); // TODO: CefListValue.SetDouble
        }
        
        /// <summary>
        /// Sets the value at the specified index as type string. Returns true if the
        /// value was set successfully.
        /// </summary>
        public int SetString(UIntPtr index, cef_string_t* value)
        {
            throw new NotImplementedException(); // TODO: CefListValue.SetString
        }
        
        /// <summary>
        /// Sets the value at the specified index as type binary. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// </summary>
        public int SetBinary(UIntPtr index, cef_binary_value_t* value)
        {
            throw new NotImplementedException(); // TODO: CefListValue.SetBinary
        }
        
        /// <summary>
        /// Sets the value at the specified index as type dict. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// </summary>
        public int SetDictionary(UIntPtr index, cef_dictionary_value_t* value)
        {
            throw new NotImplementedException(); // TODO: CefListValue.SetDictionary
        }
        
        /// <summary>
        /// Sets the value at the specified index as type list. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// </summary>
        public int SetList(UIntPtr index, cef_list_value_t* value)
        {
            throw new NotImplementedException(); // TODO: CefListValue.SetList
        }
        
    }
}
