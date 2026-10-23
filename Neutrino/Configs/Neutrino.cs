namespace Neutrino.Configs
{
    public sealed class Neutrino
    {
        public int Version { get; init; } = 1;

        public Browser Browser { get; init; } = new();

        public Plugins Plugins { get; init; } = new();

        public Window Window { get; init; } = new();

        public ContextMenu ContextMenu { get; init; } = new();
    }
}