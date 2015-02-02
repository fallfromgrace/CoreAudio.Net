﻿using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CoreAudio.Net
{
    /// <summary>
    /// is defined in propsys.h
    /// </summary>
    [ComImport]
    [SuppressUnmanagedCodeSecurity]
    [Guid("886d8eeb-8cf2-4446-8d02-cdba1dbdcf99")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPropertyStore
    {
        int GetCount(out int propCount);
        int GetAt(int property, out PropertyKey key);
        int GetValue(ref PropertyKey key, out PropVariant value);
        int SetValue(ref PropertyKey key, ref PropVariant value);
    }
}