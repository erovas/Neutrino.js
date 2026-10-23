using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace Neutrino
{
    public static class App
    {
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