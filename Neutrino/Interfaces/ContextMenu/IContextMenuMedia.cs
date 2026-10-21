namespace Neutrino.Interfaces.ContextMenu
{
    public interface IContextMenuMedia : IContextMenuTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        IContextMenuNativeItem Play { get; }

        /// <summary>
        /// 
        /// </summary>
        IContextMenuNativeItem Pause { get; }

        /// <summary>
        /// 
        /// </summary>
        IContextMenuNativeItem Mute { get; }

        /// <summary>
        /// 
        /// </summary>
        IContextMenuNativeItem Download { get; }

        /// <summary>
        /// 
        /// </summary>
        IContextMenuNativeItem OpenInNewWindow { get; }

    }
}