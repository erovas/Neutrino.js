using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace Neutrino
{
    public static class App
    {

        public static class Plugins
        {
            public const string Directory = "plugins";
        }

        public static class Window
        {
            public const string Title = "WV.js";
            public const string State = "None";

            public const int Width = 800;
            public const int Height = 600;
            public const int MinWidth = 136;
            public const int MinHeight = 39;
            public const int MaxWidth = int.MaxValue;
            public const int MaxHeight = int.MaxValue;

        }

        public static class Browser
        {
            public const string Directory = "src";

            public const string? Language = null;

            public const string Uri = "index.html";

            public const bool HotReload = false;

            public const bool AcceleratorKeys = true;

            public const bool SwipeNavigation = false;

            public const double MinZoomFactor = 0.25;

            public const double ZoomFactor = 1;

            public const double MaxZoomFactor = 5;

            public const bool Muted = false;

            public const string ColorScheme = "Auto";

        }

        /// <summary>
        /// 
        /// </summary>
        public static readonly string Directory;

        /// <summary>
        /// ["mySharedVar", "MySharedValue"]
        /// </summary>
        public static readonly ConcurrentDictionary<string, string?> Storage;

        /// <summary>
        /// Platform name
        /// </summary>
        public static readonly string Platform;


        private static bool _Initialized;

        /// <summary>
        /// Gets a boolean indicating that the application has started.
        /// </summary>
        public static bool IsInitialized
        {
            get
            {
                if (_Initialized)
                    return true;

                _Initialized = true;
                return false;
            }
        }

        /// <summary>
        /// Gets a boolean that indicates whether the application is in debug mode
        /// </summary>
        public static readonly bool IsDebugging;

        static App()
        {
            Directory = AppContext.BaseDirectory;
            Storage = new();

            string platform = OSPlatform.Windows.ToString();

            if (RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
                platform = OSPlatform.FreeBSD.ToString();
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                platform = OSPlatform.Linux.ToString();
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                platform = OSPlatform.OSX.ToString();

            Platform = platform;
            IsDebugging = System.Diagnostics.Debugger.IsAttached;
        }
    }
}