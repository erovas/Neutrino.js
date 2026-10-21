namespace Neutrino.Interfaces.ContextMenu
{
    public interface IContextMenuNativeItem
    {
        /// <summary>
        /// 
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets item kind.
        /// "Separator", "Radio", "CheckBox", "Submenu", "Command"
        /// </summary>
        string Kind { get; }

        /// <summary>
        /// Gets checked.
        /// </summary>
        bool Checked { get; set; }

        /// <summary>
        /// Gets or sets enable.
        /// </summary>
        bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets visibility.
        /// </summary>
        bool Visible { get; set; }
    }
}