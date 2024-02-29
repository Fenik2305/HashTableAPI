namespace HashTableAPI.Contracts.HashTable;

public record CreateKVPRequest(
    int Key,
    string Value);