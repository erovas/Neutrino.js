
using Neutrino.Enums;

namespace Neutrino.Configs
{
    public sealed class Browser
    {
        public string? Language { get; init; }

        public string Directory 
        { 
            get; 
            init
            {
                field = string.IsNullOrWhiteSpace(value) ? Constants.Browser.Directory : value;
            }
        } = Constants.Browser.Directory;

        public string Uri 
        { 
            get; 
            init
            {
                field = string.IsNullOrWhiteSpace(value) ? Constants.Browser.Uri : value;
            }
        } = Constants.Browser.Uri;

        public bool HotReload { get; init; } = false;

        public bool AcceleratorKeys { get; init; } = true;

        public double ZoomFactor 
        { 
            get; 
            init
            {
                if (value > Constants.Browser.MaxZoomFactor)
                    value = Constants.Browser.MaxZoomFactor;

                else if(value < Constants.Browser.MinZoomFactor)
                    value = Constants.Browser.MinZoomFactor;
                
                field = value;
            }
        } = 1;

        public bool Muted { get; init; } = false;

        public BrowserColorScheme ColorScheme { get; init; } = BrowserColorScheme.Auto;

        public int DebuggingPort { get; init; }
    }
}