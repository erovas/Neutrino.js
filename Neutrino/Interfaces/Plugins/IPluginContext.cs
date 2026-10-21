using System;
using System.Collections.Generic;
using System.Text;

namespace Neutrino.Interfaces.Plugins
{
    public interface IPluginContext
    {
        public static IPluginContext Create(INeutrino webview, string uid, string name, Action<string>? onDisposed = null)
        {
            return new PluginContext(webview, uid, name, onDisposed);
        }

        /// <summary>
        /// Instancia de Neutrino que aloja al plugin.
        /// </summary>
        INeutrino Neutrino { get; }

        /// <summary>
        /// Identidad única del plugin. Es un valor inmutable.
        /// </summary>
        string UID { get; }

        /// <summary>
        /// Nombre del plugin. Es un valor inmutable.
        /// </summary>
        string Name { get; }
    }
}
