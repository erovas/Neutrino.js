namespace Neutrino.Interfaces.ContextMenu
{
    public interface IContextMenu : IContextMenuTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        IContextMenuPage Page { get; }

        /// <summary>
        /// 
        /// </summary>
        IContextMenuImage Image { get; }

        /// <summary>
        /// 
        /// </summary>
        IContextMenuSelectedText SelectedText { get; }

        /// <summary>
        /// 
        /// </summary>
        IContextMenuMedia Media { get; }
    }
}