namespace Neutrino.Configs
{
    public sealed class ContextMenu
    {
        public ContextMenuPage Page { get; init; } = new();
        public ContextMenuImage Image { get; init; } = new();
        public ContextMenuSelectedText SelectedText { get; init; } = new();
        public ContextMenuMedia Media { get; init; } = new();
    }

    public sealed class ContextMenuPage
    {
        public ContextMenuNativeItem Back { get; init; } = new();
        public ContextMenuNativeItem Forward { get; init; } = new();
        public ContextMenuNativeItem Reload { get; init; } = new();
        public ContextMenuNativeItem SaveAs { get; init; } = new();
        public ContextMenuNativeItem InspectElement { get; init; } = new();
    }

    public sealed class ContextMenuImage
    {
        public ContextMenuNativeItem SaveImageAs { get; init; } = new();
        public ContextMenuNativeItem CopyImage { get; init; } = new();
        public ContextMenuNativeItem CopyImageURL { get; init; } = new();
    }

    public sealed class ContextMenuSelectedText
    {
        public ContextMenuNativeItem Copy { get; init; } = new();
        public ContextMenuNativeItem Cut { get; init; } = new();
        public ContextMenuNativeItem CopyImageURL { get; init; } = new();
        public ContextMenuNativeItem Paste { get; init; } = new();
        public ContextMenuNativeItem SelectAll { get; init; } = new();
        public ContextMenuNativeItem SearchTheWeb { get; init; } = new();
    }

    public sealed class ContextMenuMedia
    {
        public ContextMenuNativeItem Play { get; init; } = new();
        public ContextMenuNativeItem Pause { get; init; } = new();
        public ContextMenuNativeItem Mute { get; init; } = new();
        public ContextMenuNativeItem Download { get; init; } = new();
        public ContextMenuNativeItem OpenInNewWindow { get; init; } = new();
    }

    public sealed class ContextMenuNativeItem
    {
        public bool Enabled { get; init; } = true;
        public bool Visible { get; init; } = true;
    }
}