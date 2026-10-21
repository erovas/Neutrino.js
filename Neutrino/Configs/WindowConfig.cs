using System.Text.Json.Serialization;

namespace Neutrino.Configs
{
    public sealed class WindowConfig
    {
        public string Title { get; }
        public string State { get; }
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
        public WindowConfig(
            string title = App.Window.Title,
            string state = App.Window.State,
            bool centerScreen = false,
            int x = 0, int y = 0,
            int width = App.Window.Width, int height = App.Window.Height,
            int maxWidth = App.Window.MaxWidth, int maxHeight = App.Window.MaxHeight,
            int minWidth = App.Window.MinWidth, int minHeight = App.Window.MinHeight)
        {
            Title = title;
            State = state;
            CenterScreen = centerScreen;

            X = x;
            Y = y;

            // MinValue nunca puede ser menor que AppManager.MinWindowValue
            MinWidth = Math.Max(minWidth, App.Window.MinWidth);
            MinHeight = Math.Max(minHeight, App.Window.MinHeight);

            // MaxValue nunca puede ser menor que MinValue
            MaxWidth = Math.Max(maxWidth, MinWidth);
            MaxHeight = Math.Max(maxHeight, MinHeight);

            // Aplicamos el clamp después de tener Min/Max calculados
            Width = Utils.Clamp(width, MinWidth, MaxWidth);
            Height = Utils.Clamp(height, MinHeight, MaxHeight);
        }
    }
}