namespace Neutrino.Configs
{
    public sealed class NeutrinoConfig
    {
        public int Version { get; init; } = 1;

        public BrowserConfig Browser { get; init; } = new();

        public PluginsConfig Plugins { get; init; } = new();

        public WindowConfig Window { get; init; } = new();

    }
}