using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBamboozle.Bootstrap
{

    public enum ColorName
    {
        None,
        Danger,
        Warning,
        Success,
        Info,
        Primary,
        Light,
        Dark,
        Secondary
    }


    public static class BootstrapExtensions
    {
        public static string ToClass(this ColorName c) => c.ToString().ToLower();
    }
}
