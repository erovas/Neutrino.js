using Neutrino;
using Neutrino.Interfaces.Plugins;
using System.Collections.Concurrent;

public class Storage : Plugin
{
    private ConcurrentDictionary<string, string?> Data;

    public Storage(IPluginContext context) : base(context)
    {
        Data = App.Storage;
    }

    public int Count
    {
        get
        {
            ThrowExceptionIfDisposed();
            return Data.Count;
        }
    }

    public string[] Keys
    {
        get
        {
            ThrowExceptionIfDisposed();
            return Data.Keys.ToArray();
        }
    }

    public object?[] Values
    {
        get
        {
            ThrowExceptionIfDisposed();
            return Data.Values.ToArray();
        }
    }


    public bool Add(string key, string value)
    {
        ThrowExceptionIfDisposed();
        return Data.TryAdd(key, value);
    }

    public void Clear()
    {
        ThrowExceptionIfDisposed();
        Data.Clear();
    }

    public bool Contains(string key)
    {
        ThrowExceptionIfDisposed();
        return Data.ContainsKey(key);
    }

    public string? Get(string key)
    {
        ThrowExceptionIfDisposed();
        return Data[key];
    }

    public bool Remove(string key)
    {
        ThrowExceptionIfDisposed();
        return Data.TryRemove(key, out _);
    }

    public void Set(string key, string value)
    {
        ThrowExceptionIfDisposed();
        Data[key] = value;
    }

    protected override void Dispose(bool disposing)
    {
        Data = new();
    }
}