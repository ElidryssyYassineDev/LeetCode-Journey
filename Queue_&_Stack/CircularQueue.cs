public class MyCircularQueue
{
    private int[] queue;
    private int head;
    private int tail;
    private int count;
    private int capacity;

    public MyCircularQueue(int k)
    {
        queue = new int[k];
        capacity = k;
        head = 0;
        tail = 0;
        count = 0;
    }

    public bool EnQueue(int value)
    {
        if (IsFull())
            return false;

        queue[tail] = value;
        tail = (tail + 1) % capacity;
        count++;

        return true;
    }

    public bool DeQueue()
    {
        if (IsEmpty())
            return false;

        head = (head + 1) % capacity;
        count--;

        return true;
    }

    public int Front()
    {
        if (IsEmpty())
            return -1;

        return queue[head];
    }

    public int Rear()
    {
        if (IsEmpty())
            return -1;

        int index = (tail - 1 + capacity) % capacity;
        return queue[index];
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    public bool IsFull()
    {
        return count == capacity;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */