using Neutrino.Enums;
using System.Text.Json.Serialization;

namespace Neutrino.Configs
{
    public sealed class Window
    {
        public string Title { get; }
        public WindowState State { get; }
        public bool Visible { get; }
        public bool Enabled { get; }
        public bool CenterScreen { get; }

        public int X { get; }
        public int Y { get; }
        public int Width { get; }
        public int Height { get; }

        public int MaxWidth { get; }
        public int MaxHeight { get; }

        public int MinWidth { get; }
        public int MinHeight { get; }

        [JsonConstructor]
        public Window(
            string title = Constants.Window.Title,
            WindowState state = WindowState.Restored,
            bool visible = false,
            bool enabled = true,
            bool centerScreen = false,
            int x = 0, int y = 0,
            int width = Constants.Window.Width, int height = Constants.Window.Height,
            int maxWidth = Constants.Window.MaxWidth, int maxHeight = Constants.Window.MaxHeight,
            int minWidth = Constants.Window.MinWidth, int minHeight = Constants.Window.MinHeight)
        {
            Title = title + "";
            State = state;
            Visible = visible;
            Enabled = enabled;
            CenterScreen = centerScreen;

            X = x;
            Y = y;

            // MinValue nunca puede ser menor que AppManager.MinWindowValue
            MinWidth = Math.Max(minWidth, Constants.Window.MinWidth);
            MinHeight = Math.Max(minHeight, Constants.Window.MinHeight);

            // MaxValue nunca puede ser menor que MinValue
            MaxWidth = Math.Max(maxWidth, MinWidth);
            MaxHeight = Math.Max(maxHeight, MinHeight);

            // Aplicamos el clamp después de tener Min/Max calculados
            Width = Clamp(width, MinWidth, MaxWidth);
            Height = Clamp(height, MinHeight, MaxHeight);
        }

        private static int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;

            if (value > max)
                return max;

            return value;
        }
    }
}