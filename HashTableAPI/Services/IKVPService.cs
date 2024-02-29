using HashTableAPI.Models;

namespace HashTableAPI.Services
{
    public interface IKVPService
    {
        void AddKVP(KVP kvp);
        void DeleteKVP(int key);
        KVP GetKVP(int key);
        void UpdateKVP(KVP kvp);
    }
}
