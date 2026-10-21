namespace Neutrino.Interfaces.Plugins
{
    public interface IPlugins
    {
        #region Properties

        /// <summary>
        /// Gets a read only array containing the metadata of all loaded plugins
        /// </summary>
        IPluginMetadata[] Loaded { get; }

        /// <summary>
        /// 
        /// </summary>
        string Directory { get; }

        #endregion

        //-------------------------------------------//

        #region Methods

        /// <summary>
        /// Create an instance of a plugin
        /// </summary>
        /// <param name="pluginName"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        object NewInstance(string pluginName, params object[] args);

        /// <summary>
        /// Retrieves a plugin instance using its UID
        /// </summary>
        /// <param name="UID"></param>
        /// <returns></returns>
        object GetInstance(string UID);

        /// <summary>
        /// Load plugins from folder
        /// </summary>
        /// <param name="foldePath"></param>
        /// <returns></returns>
        IPluginLoadResult[] LoadFrom(string? foldePath = null);

        /// <summary>
        /// Load plugin from path
        /// </summary>
        /// <param name="pluginPath"></param>
        IPluginLoadResult Load(string pluginPath);

        /// <summary>
        /// Unload plugin by name
        /// </summary>
        /// <param name="pluginName"></param>
        void Unload(string pluginName);

        #endregion
    }
}