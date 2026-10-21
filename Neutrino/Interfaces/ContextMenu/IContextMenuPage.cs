namespace Neutrino.Interfaces.ContextMenu
{
    public interface IContextMenuPage : IContextMenuTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        IContextMenuNativeItem Back { get; }

        /// <summary>
        /// 
        /// </summary>
        IContextMenuNativeItem Forward { get; }

        /// <summary>
        /// 
        /// </summary>
        IContextMenuNativeItem Reload { get; }

        /// <summary>
        /// 
        /// </summary>
        IContextMenuNativeItem SaveAs { get; }

        /// <summary>
        /// 
        /// </summary>
        IContextMenuNativeItem InspectElement { get; }
    }
}