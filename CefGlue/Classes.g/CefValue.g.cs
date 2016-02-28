//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefValue : IDisposable
    {
        internal static CefValue FromNative(cef_value_t* ptr)
        {
            return new CefValue(ptr);
        }
        
        internal static CefValue FromNativeOrNull(cef_value_t* ptr)
        {
            if (ptr == null) return null;
            return new CefValue(ptr);
        }
        
        private cef_value_t* _self;
        
        private CefValue(cef_value_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefValue()
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
            cef_value_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_value_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_value_t.has_one_ref(_self) != 0; }
        }
        
        internal cef_value_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
