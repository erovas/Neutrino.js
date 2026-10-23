using Neutrino.Interfaces.Plugins;
using System.Reflection;

namespace Neutrino
{
    public abstract class Plugin : IDisposable
    {
        #region Fields

        private readonly PluginContext _context;
        private int _disposed;

        #endregion

        #region Properties

        protected Neutrino Neutrino => _context.Neutrino;

        public string UID => _context.UID;

        public string Name => _context.Name;

        public bool Disposed => Volatile.Read(ref _disposed) == 1;

        #endregion

        protected Plugin(IPluginContext context)
        {
            if (App.IsInitialized && context.Neutrino is null)
                throw new NullReferenceException("Context.Neutrino cannot be null.");

            _context = (PluginContext)context;

            if (_context.Asignated)
                throw new InvalidOperationException("The plugin context belongs to another plugin.");

            _context.Asignated = true;
            _context._neutrino ??= (Neutrino)this;
        }

        public void Dispose()
        {
            CleanUp(true);
            GC.SuppressFinalize(this);
        }

        ~Plugin()
        {
            CleanUp(false);
        }

        protected virtual void ClearEvents()
        {
            const BindingFlags flags =
                BindingFlags.Instance |
                BindingFlags.NonPublic |
                BindingFlags.Public |
                BindingFlags.DeclaredOnly;

            var type = this.GetType();
            var fields = new List<FieldInfo>();

            for (var t = type; t != null && t != typeof(object); t = t.BaseType)
            {
                foreach (var evt in t.GetEvents(flags))
                {
                    // Para un evento field-like, el campo de respaldo se llama igual.
                    var field = t.GetField(evt.Name, flags);
                    if (field != null)
                        fields.Add(field);
                }
            }

            // Asignación directa al campo: no invoca remove().
            foreach (var f in fields)
                f.SetValue(this, null);
        }

        private void CleanUp(bool disposing)
        {
            if (Interlocked.Exchange(ref _disposed, 1) == 1)
                return;

            try
            {
                if (disposing)
                    ClearEvents();
                
                Dispose(disposing);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                try
                {
                    _context.OnDisposed?.Invoke(UID);
                }
                catch (Exception)
                {
                    
                }

                _context.Release();
            }
        }

        protected void ThrowExceptionIfDisposed()
        {
            if(Disposed)
                throw new ObjectDisposedException($"This instance of the {Name} plugin is disposed");
        }

        protected abstract void Dispose(bool disposing);

    }
}