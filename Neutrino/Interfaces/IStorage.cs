namespace Neutrino.Interfaces
{
    public interface IStorage
    {
        string? Get(string key);

        bool Add(string key, string value);

        void Set(string key, string value);

        int Count { get; }

        bool Contains(string key);

        void Clear();

        bool Remove(string key);
    }
}