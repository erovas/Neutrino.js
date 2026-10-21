namespace Neutrino.Interfaces
{
    public interface IStorage
    {
        string Get(string key);

        void Add(string key, string value);

        void Set(string key, string value);

        int Count { get; }

        bool Contains(string key);

        void Clear();

        void Remove(string key);
    }
}