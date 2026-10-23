using Neutrino.Enums;

namespace Neutrino.Interfaces
{
    public interface IBrowser
    {
        #region Events

        /// <summary>
        /// PlayingAudio Event 
        /// </summary>
        event EventHandler<bool> PlayingAudio;

        /// <summary>
        /// Muted Event 
        /// </summary>
        event EventHandler<bool> MutedEvent;

        /// <summary>
        /// ZoomFactorChanged Event 
        /// </summary>
        event EventHandler<double> ZoomFactorChanged;

        /// <summary>
        /// StatusBarTextChanged Event
        /// </summary>
        event EventHandler<string> StatusBarTextChanged;

        #endregion

        //-------------------------------------------//

        #region Properties

        /// <summary>
        /// Enable or disable automatic browser reloading, use it during development. Default value is false.
        /// </summary>
        bool HotReload { get; set; }

        /// <summary>
        /// Indicates whether any audio output from this CoreWebView2 is playing. 
        /// true if audio is playing even if IBrowser.Muted is true.
        /// </summary>
        bool IsPlayingAudio { get; }

        /// <summary>
        /// Determines whether browser-specific accelerator keys are enabled.
        /// 
        /// <para>
        /// When this setting is set to false, it disables all accelerator keys that access
        /// features specific to a web browser, including but not limited to:
        /// • Ctrl+F and F3 for Find on Page
        /// • Ctrl+P for Print
        /// • Ctrl+R and F5 for Reload
        /// • Ctrl+Plus and Ctrl+Minus for zooming
        /// • Ctrl+Shift-C and F12 for DevTools
        /// • Special keys for browser functions, such as Back, Forward, and Search
        /// It does not disable accelerator keys related to movement and text editing, such as:
        /// • Home, End, Page Up, and Page Down
        /// • Ctrl+X, Ctrl+C, Ctrl+V
        /// • Ctrl+A for Select All
        /// • Ctrl+Z for Undo
        /// </para>
        /// </summary>
        bool AcceleratorKeys { get; set; }

        /// <summary>
        /// Gets or sets the zoom factor for the WebView.
        /// 
        /// <para>
        /// Note that changing zoom factor may cause window.innerWidth or window.innerHeight
        /// and page layout to change.A zoom factor that is applied by the host by setting
        /// this ZoomFactor property becomes the new default zoom for the WebView.This zoom
        /// factor applies across navigations and is the zoom factor WebView is returned
        /// to when the user presses Ctrl+0. Specifying a ZoomFactor less than
        /// or equal to 0 is not allowed. WebView also has an internal supported zoom factor
        /// range.When a specified zoom factor is out of that range, it is normalized to
        /// be within the range event is raised for the real applied zoom factor. 
        /// </para>
        /// </summary>
        double ZoomFactor { get; set; }

        /// <summary>
        /// Gets maximum ZommFactor.
        /// </summary>
        public double MaxZoomFactor { get; }

        /// <summary>
        /// Gets minimum ZoomFactor.
        /// </summary>
        public double MinZoomFactor { get; }

        /// <summary>
        /// Indicates whether all audio output from this WebView2 is muted or not. Set
        /// to true will mute this CoreWebView2, and set to false will unmute this WebView2.
        /// true if audio is muted.
        /// </summary>
        bool Muted { get; set; }

        /// <summary>
        /// Gets or sets the browser's color scheme. Default value is "Auto"
        /// </summary>
        BrowserColorScheme ColorScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string Directory { get; }

        #endregion

        //-------------------------------------------//

        #region Methods

        /// <summary>
        /// Open inspector.
        /// </summary>
        void OpenInspector();

        /// <summary>
        /// Reload the page avoiding the cache.
        /// </summary>
        void Reload();

        #endregion

    }
}