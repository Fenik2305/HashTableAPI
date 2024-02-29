namespace HashTableAPI.Models
{
    public class KVP
    {
        public int Key { get; }
        public string Value { get; }
        public KVP(int key, string value)
        {
            //enforce invariants
            Key = key;
            Value = value;
        }
    }
}
