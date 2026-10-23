namespace Neutrino.Interfaces.Plugins
{
    public interface IPluginContext
    {
        public static IPluginContext Create(Neutrino neutrino, string uid, string name, Action<string>? onDisposed = null)
        {
            return new PluginContext(neutrino, uid, name, onDisposed);
        }

        /// <summary>
        /// Instancia de Neutrino que aloja al plugin.
        /// </summary>
        Neutrino Neutrino { get; }

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
