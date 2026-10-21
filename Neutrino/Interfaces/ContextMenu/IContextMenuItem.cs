namespace Neutrino.Interfaces.ContextMenu
{
    public interface IContextMenuItem : IContextMenuTemplate
    {
        #region Properties

        /// <summary>
        /// Text to show.
        /// </summary>
        string Label { get; set; }

        /// <summary>
        /// Gets or sets item kind.
        /// Case insensitive:
        /// "Separator", "Radio", "CheckBox", "Submenu", "Command"
        /// </summary>
        string Kind { get; set; }

        /// <summary>
        /// Gets or sets checked.
        /// </summary>
        bool Checked { get; set; }

        /// <summary>
        /// Gets or sets action function
        /// </summary>
        Action<IContextMenuItem>? Action { get; set; }

        #endregion

    }
}