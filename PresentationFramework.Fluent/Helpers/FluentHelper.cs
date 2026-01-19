using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;

namespace PresentationFramework.Fluent
{
    public static class FluentHelper
    {
        public const string LightThemePath = "/PresentationFramework.Fluent;component/Themes/Fluent.Light.xaml";
        public const string DarkThemePath = "/PresentationFramework.Fluent;component/Themes/Fluent.Dark.xaml";
        public const string HCThemePath = "/PresentationFramework.Fluent;component/Themes/Fluent.HC.xaml";

        public static Uri LightThemeUri => new Uri(LightThemePath, UriKind.Relative);
        public static Uri DarkThemeUri => new Uri(DarkThemePath, UriKind.Relative);
        public static Uri HCThemeUri => new Uri(HCThemePath, UriKind.Relative);
    }
}
