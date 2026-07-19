public class MyHashSet {
    int CAPACITY = 10000;
    LinkedList<int>[] buckets;
    
    public int hash (int key) {
        return key % CAPACITY;
    }

    public MyHashSet() {
        buckets = new LinkedList<int>[CAPACITY];
        
        for (int i = 0; i < CAPACITY; ++i){
            buckets[i] = new LinkedList<int>();
        }
    }
    
    public void Add(int key) {
        int index = hash(key);
        foreach (int value in buckets[index]){
            if (value == key) return;
        }
        buckets[index].AddLast(key);
    }
    
    public void Remove(int key) {
        int index = hash(key);
        buckets[index].Remove(key);
    }
    
    public bool Contains(int key) {
        int index = hash(key);
        foreach (int value in buckets[index]){
            if (value == key){
                return true;
            }
        }
        return false;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */