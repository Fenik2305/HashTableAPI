using HashTableAPI.Models;

namespace HashTableAPI.Services
{
    public class KVPService : IKVPService
    {
        private static readonly Dictionary<int, KVP> _hashTable = new();

        public void AddKVP(KVP kvp)
        {
            _hashTable.Add(kvp.Key, kvp);
        }

        public void DeleteKVP(int key)
        {
            _hashTable.Remove(key);
        }

        public KVP GetKVP(int key)
        {
            return _hashTable[key];
        }

        public void UpdateKVP(KVP kvp)
        {
            _hashTable[kvp.Key] = kvp;
        }
    }
}
