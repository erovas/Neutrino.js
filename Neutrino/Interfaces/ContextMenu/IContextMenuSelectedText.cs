namespace Neutrino.Interfaces.ContextMenu
{
    public interface IContextMenuSelectedText : IContextMenuTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        IContextMenuNativeItem Copy { get; }

        /// <summary>
        /// 
        /// </summary>
        IContextMenuNativeItem Cut { get; }

        /// <summary>
        /// 
        /// </summary>
        IContextMenuNativeItem Paste { get; }

        /// <summary>
        /// 
        /// </summary>
        IContextMenuNativeItem SelectAll { get; }

        /// <summary>
        /// 
        /// </summary>
        IContextMenuNativeItem SearchTheWeb { get; }
    }
}