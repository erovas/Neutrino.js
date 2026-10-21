namespace Neutrino.Interfaces.Plugins
{
    internal class PluginContext : IPluginContext
    {
        internal INeutrino? _neutrino;
        private Action<string>? _onDisposed;
        private int _released;

        /// <summary>
        /// WebView que aloja al plugin. Puede ser null tras llamar a <see cref="Release"/>.
        /// </summary>
        public INeutrino Neutrino => Volatile.Read(ref _neutrino)!;

        /// <summary>
        /// Identidad única del plugin. Es un valor inmutable.
        /// </summary>
        public string UID { get; }

        /// <summary>
        /// Nombre del plugin. Es un valor inmutable.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Callback que el webview registró para enterarse de la liberación del plugin.
        /// Puede ser null tras llamar a <see cref="Release"/>.
        /// </summary>
        internal Action<string>? OnDisposed => Volatile.Read(ref _onDisposed);

        /// <summary>
        /// Indica si el contexto ya fue liberado con <see cref="Release"/>.
        /// </summary>
        internal bool IsReleased => Volatile.Read(ref _released) == 1;

        /// <summary>
        /// 
        /// </summary>
        internal bool Asignated { get; set; }

        internal PluginContext(INeutrino webview, string uid, string name, Action<string>? onDisposed = null)
        {
            _neutrino = webview;
            UID = uid;
            Name = name;
            _onDisposed = onDisposed;
        }

        /// <summary>
        /// Suelta las referencias que apuntan al host (Host y OnDisposed) para romper
        /// el ciclo WebView ↔ Plugin ↔ PluginContext.
        ///
        /// No es un Dispose: no hay recursos del sistema que liberar. Solo se sueltan
        /// referencias administradas para que el GC pueda recoger al host cuando ya
        /// no sea usado por nadie más.
        ///
        /// Es idempotente y thread-safe.
        /// </summary>
        internal void Release()
        {
            // Garantiza una sola ejecución aunque varios hilos lo llamen.
            if (Interlocked.Exchange(ref _released, 1) == 1)
                return;

            // Suelta las dos vías hacia el host:
            //  1. La referencia directa (Host).
            //  2. La referencia a través del target del delegate (OnDisposed).
            Volatile.Write(ref _neutrino, null);
            Volatile.Write(ref _onDisposed, null);
        }
    }
}