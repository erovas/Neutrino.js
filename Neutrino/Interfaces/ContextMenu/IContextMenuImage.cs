using static System.Net.Mime.MediaTypeNames;

namespace Neutrino.Interfaces.ContextMenu
{
    public interface IContextMenuImage : IContextMenuTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        IContextMenuNativeItem SaveImageAs { get; }

        /// <summary>
        /// 
        /// </summary>
        IContextMenuNativeItem CopyImage { get; }

        /// <summary>
        /// 
        /// </summary>
        IContextMenuNativeItem CopyImageURL { get; }

    }
}