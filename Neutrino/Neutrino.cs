using Neutrino.Configs;
using Neutrino.Interfaces;
using Neutrino.Interfaces.Plugins;
using Neutrino.Interfaces.ContextMenu;

namespace Neutrino
{
    public abstract class Neutrino : Plugin
    {
        
        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public IWindow Window { get; }

        /// <summary>
        /// 
        /// </summary>
        public IBrowser Browser { get; }

        /// <summary>
        /// 
        /// </summary>
        public IContextMenu ContextMenu { get; }

        /// <summary>
        /// 
        /// </summary>
        public IPlugins Plugins { get; }

        /// <summary>
        /// Gets a value that indicates wheter this Neutrino instance is the main.
        /// </summary>
        public bool IsMain { get; }

        #endregion

        protected Neutrino(IPluginContext context, Configs.Neutrino config) : base(context)
        {
            IsMain = Neutrino == this;
            Window = CreateWindow(config.Window);
            Browser = CreateBrowser(config.Browser);
            ContextMenu = CreateContextMenu(config.ContextMenu);
            Plugins = CreatePlugins(config.Plugins);
        }

        protected abstract IWindow CreateWindow(Window config);

        protected abstract IBrowser CreateBrowser(Browser config);

        protected abstract IContextMenu CreateContextMenu(ContextMenu config);

        protected abstract IPlugins CreatePlugins(Plugins config);
    }
}