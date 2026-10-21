using Neutrino.Interfaces.ContextMenu;
using Neutrino.Interfaces.Plugins;

namespace Neutrino.Interfaces
{
    public interface INeutrino : IDisposable
    {
        #region Properties

        /// <summary>
        /// 
        /// </summary>
        IStorage Storage { get; }

        /// <summary>
        /// 
        /// </summary>
        IWindow Window { get; }

        /// <summary>
        /// 
        /// </summary>
        IBrowser Browser { get; }

        /// <summary>
        /// 
        /// </summary>
        IContextMenu ContextMenu { get; }

        /// <summary>
        /// 
        /// </summary>
        IPlugins Plugins { get; }

        /// <summary>
        /// Gets a value that indicates wheter this Neutrino instance is the main.
        /// </summary>
        bool IsMain { get; }

        /// <summary>
        /// 
        /// </summary>
        bool Disposed { get; }

        #endregion
    }
}