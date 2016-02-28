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
    public sealed unsafe partial class CefMenuModel : IDisposable
    {
        internal static CefMenuModel FromNative(cef_menu_model_t* ptr)
        {
            return new CefMenuModel(ptr);
        }
        
        internal static CefMenuModel FromNativeOrNull(cef_menu_model_t* ptr)
        {
            if (ptr == null) return null;
            return new CefMenuModel(ptr);
        }
        
        private cef_menu_model_t* _self;
        
        private CefMenuModel(cef_menu_model_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefMenuModel()
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
            cef_menu_model_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_menu_model_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_menu_model_t.has_one_ref(_self) != 0; }
        }
        
        internal cef_menu_model_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
