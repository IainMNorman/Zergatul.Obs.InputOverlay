﻿using System;

namespace Earthware.PrimeGskMirror.GamepadHandler;

public static class WinApiHelper
{
    public static string FormatWin32Error(int errorCode)
    {
        if (Enum.IsDefined((WinApi.Win32Error)errorCode))
        {
            return $"({(WinApi.Win32Error)errorCode} hex={FormatErrorCode(errorCode)} dec={errorCode})";
        }
        else
        {
            return $"(hex={FormatErrorCode(errorCode)} dec={errorCode})";
        }
    }

    internal static string FormatHidPStatus(WinApi.Hid.HidPStatus status)
    {
        if (Enum.IsDefined(status))
        {
            return $"({status} hex={FormatErrorCode((int)status)} dec={(int)status})";
        }
        else
        {
            return $"(hex={FormatErrorCode((int)status)} dec={(int)status})";
        }
    }

    private static string FormatErrorCode(int code)
    {
        return "0x" + code.ToString("X2").PadLeft(8, '0');
    }

    public static string FormatIntPtr(IntPtr ptr)
    {
        return "0x" + ptr.ToInt64().ToString("X2").PadLeft(16, '0');
    }

    public static string FormatInt16(int value)
    {
        return "0x" + value.ToString("X2").PadLeft(4, '0');
    }
}