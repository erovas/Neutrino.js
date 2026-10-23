using Neutrino.Enums;

namespace Neutrino.Interfaces
{
    public interface IWindow
    {
        #region Events

        /// <summary>
        /// StateChanged event.
        /// </summary>
        event EventHandler<string> StateChanged;

        /// <summary>
        /// Close event.
        /// </summary>
        event EventHandler Closing;

        /// <summary>
        /// PositionChanged event.
        /// </summary>
        event EventHandler<int, int> PositionChanged;

        /// <summary>
        /// Activated event.
        /// </summary>
        event EventHandler<bool> Activated;

        /// <summary>
        /// Enabled event.
        /// </summary>
        event EventHandler<bool> EnabledEvent;

        /// <summary>
        /// Visible event.
        /// </summary>
        event EventHandler<bool> VisibleEvent;

        /// <summary>
        /// Size Changed event.
        /// </summary>
        event EventHandler<int, int> SizeChanged;

        /// <summary>
        /// Raw event for platform specific
        /// </summary>
        event EventHandler<object> Raw;

        #endregion

        //-------------------------------------------//

        #region Properties

        /// <summary>
        /// Gets or sets a window title.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Gets or sets window state.
        /// </summary>
        WindowState State { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether this window appears in the topmost z-order.
        /// <para>
        /// true if the window is topmost; otherwise, false.
        /// </para>
        /// </summary>
        bool TopMost { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this window is enabled in the user interface (UI)
        /// <para>
        /// true if the window is enabled; otherwise, false. The default value is true.
        /// </para>
        /// </summary>
        bool Enabled { get; set; }

        /// <summary>
        /// Gets a value that indicates whether this window is visible.
        /// <para>
        /// true if the window is visible; otherwise, false. The default value is false.
        /// </para>
        /// </summary>
        bool Visible { get; set; }

        /// <summary>
        /// Prevents the window from closing, and fires the OnClose event
        /// </summary>
        bool PreventClose { get; set; }

        /// <summary>
        /// Gets a value that indicates whether this window is active.
        /// </summary>
        bool IsActive { get; }

        /// <summary>
        /// Window position in X.
        /// </summary>
        int X { get; set; }

        /// <summary>
        /// Window position in Y.
        /// </summary>
        int Y { get; set; }

        /// <summary>
        /// Window width.
        /// </summary>
        int Width { get; set; }

        /// <summary>
        /// Window Height.
        /// </summary>
        int Height { get; set; }

        /// <summary>
        /// Maximum window width.
        /// </summary>
        int MaxWidth { get; set; }

        /// <summary>
        /// Maximum window height.
        /// </summary>
        int MaxHeight { get; set; }

        /// <summary>
        /// Minimun window width. Minimun value is 136.
        /// </summary>
        int MinWidth { get; set; }

        /// <summary>
        /// Minimun window height. Minimun value is 39.
        /// </summary>
        int MinHeight { get; set; }

        #endregion

        //-------------------------------------------//

        #region Methods

        /// <summary>
        /// Moves the window to the center of the screen
        /// </summary>
        void ToCenter();

        /// <summary>
        /// Close the window
        /// </summary>
        void Close();

        /// <summary>
        /// Shows the window without activating it
        /// </summary>
        void ShowBehind();

        /// <summary>
        /// Shows the window
        /// </summary>
        void Show();

        /// <summary>
        /// Hide the window
        /// </summary>
        void Hide();

        /// <summary>
        /// Drag the window
        /// </summary>
        void Drag();

        /// <summary>
        /// Resize top-left the window
        /// </summary>
        void ResizeTopLeft();

        /// <summary>
        /// Resize top-right the window
        /// </summary>
        void ResizeTopRight();

        /// <summary>
        /// Resize bottom-left the window
        /// </summary>
        void ResizeBottomLeft();

        /// <summary>
        /// Resize bottom-right the window
        /// </summary>
        void ResizeBottomRight();

        /// <summary>
        /// Resize left the window
        /// </summary>
        void ResizeLeft();

        /// <summary>
        /// Resize right the window
        /// </summary>
        void ResizeRight();

        /// <summary>
        /// Resize top the window
        /// </summary>
        void ResizeTop();

        /// <summary>
        /// Resize bottom the window
        /// </summary>
        void ResizeBottom();

        /// <summary>
        /// Minimize the window
        /// </summary>
        void Minimize();

        /// <summary>
        /// Restore the window
        /// </summary>
        void Restore();

        /// <summary>
        /// Maximize the window
        /// </summary>
        void Maximize();

        /// <summary>
        /// Normalize the window
        /// </summary>
        void Normalize();

        /// <summary>
        /// Set size of window.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        void SetSize(int width, int height);

        /// <summary>
        /// Get size of window.
        /// </summary>
        /// <returns></returns>
        int[] GetSize();

        /// <summary>
        /// Set position of window.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void SetPosition(int x, int y);

        /// <summary>
        /// Get position of window.
        /// </summary>
        /// <returns></returns>
        int[] GetPosition();

        /// <summary>
        /// Set position and size of window.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        void SetPositionAndSize(int x, int y, int width, int height);

        /// <summary>
        /// Get position and size of window.
        /// </summary>
        /// <returns></returns>
        int[] GetPositionAndSize();

        #endregion

    }
}