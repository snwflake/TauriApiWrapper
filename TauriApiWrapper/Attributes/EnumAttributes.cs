﻿using System;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Attributes
{
    internal static class EnumAttributes
    {
        internal static string ToName(this Enum val)
        {
            NameAttribute[] attributes = (NameAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(NameAttribute), false);
            return attributes.Length > 0 ? attributes[0].Name : string.Empty;
        }
    }
}