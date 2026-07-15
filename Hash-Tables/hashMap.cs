public class MyHashMap {
    public int CAPACITY = 1009;
    public class Pair {
        public int Key;
        public int Value;
        public Pair(int key, int value) {
            Key = key;
            Value = value;
        }
    }
    public LinkedList<Pair>[] buckets;
    public int Hash(int key) {
        return key % CAPACITY;
    }

    public MyHashMap() {
        buckets = new LinkedList<Pair>[CAPACITY];
        for (int i = 0; i < CAPACITY; ++i){
            buckets[i] = new LinkedList<Pair>();
        }
    }
    
    public void Put(int key, int value) {
        int index = Hash(key);
        foreach(Pair pair in buckets[index]){
            if(pair.Key == key){
                pair.Value = value;
                return;
            }
        }
        buckets[index].AddLast(new Pair(key, value));
    }
    
    public int Get(int key) {
        int index = Hash(key);
        foreach(Pair pair in buckets[index]){
            if (pair.Key == key){
                return pair.Value;
            }
        }
        return -1;
    }
    
    public void Remove(int key) {
        int index = Hash(key);
        LinkedListNode<Pair>? current = buckets[index].First;
        
        while (current != null){
            if (current.Value.Key == key){
                buckets[index].Remove(current);
                return;
            }
            current = current.Next;
        }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */