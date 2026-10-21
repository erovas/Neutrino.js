namespace Neutrino.Interfaces.ContextMenu
{
    public interface IContextMenuTemplate
    {
        #region Properties

        /// <summary>
        /// Gets items count
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Gets or sets enable.
        /// </summary>
        bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets visibility.
        /// </summary>
        bool Visible { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the item by index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        IContextMenuItem GetItem(int index);

        /// <summary>
        /// Add the item to the end of the submenu.
        /// </summary>
        /// <param name="item"></param>
        void AddItem(IContextMenuItem item);

        /// <summary>
        /// Insert the item at the specified position of the submenu.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        void InsertItem(int index, IContextMenuItem item);

        /// <summary>
        /// Removes the item of the submenu. Return true if removed.
        /// </summary>
        /// <param name="item"></param>
        void RemoveItem(IContextMenuItem item);

        /// <summary>
        /// Removes the item to the specified position of the submenu.
        /// </summary>
        /// <param name="index"></param>
        void RemoveItemAt(int index);

        /// <summary>
        /// Remove all items of the submenu.
        /// </summary>
        void Clear();

        #endregion
    }
}