public class MyLinkedList
{
    public class Node
    {
        public int val;
        public Node next;
        public Node prev;

        public Node(int val)
        {
            this.val = val;
        }
    }

    public int size;
    public Node head;
    public Node tail;

    public MyLinkedList()
    {
        size = 0;
        head = new Node(0);
        tail = new Node(0);

        head.next = tail;
        tail.prev = head;
    }

    public int Get(int index)
    {
        if (index < 0 || index >= size)
            return -1;

        Node curr;

        if (index < size / 2)
        {
            curr = head.next;
            for (int i = 0; i < index; i++)
                curr = curr.next;
        }
        else
        {
            curr = tail.prev;
            for (int i = size - 1; i > index; i--)
                curr = curr.prev;
        }

        return curr.val;
    }

    public void AddAtHead(int val)
    {
        Node pred = head;
        Node succ = head.next;

        Node node = new Node(val);

        node.prev = pred;
        node.next = succ;

        pred.next = node;
        succ.prev = node;

        size++;
    }

    public void AddAtTail(int val)
    {
        Node pred = tail.prev;
        Node succ = tail;

        Node node = new Node(val);

        node.prev = pred;
        node.next = succ;

        pred.next = node;
        succ.prev = node;

        size++;
    }

    public void AddAtIndex(int index, int val)
    {
        if (index < 0 || index > size)
            return;

        if (index == 0)
        {
            AddAtHead(val);
            return;
        }

        if (index == size)
        {
            AddAtTail(val);
            return;
        }

        Node curr;

        if (index < size / 2)
        {
            curr = head.next;
            for (int i = 0; i < index; i++)
                curr = curr.next;
        }
        else
        {
            curr = tail.prev;
            for (int i = size - 1; i > index; i--)
                curr = curr.prev;
        }

        Node pred = curr.prev;

        Node node = new Node(val);

        node.prev = pred;
        node.next = curr;

        pred.next = node;
        curr.prev = node;

        size++;
    }

    public void DeleteAtIndex(int index)
    {
        if (index < 0 || index >= size)
            return;

        Node curr;

        if (index < size / 2)
        {
            curr = head.next;
            for (int i = 0; i < index; i++)
                curr = curr.next;
        }
        else
        {
            curr = tail.prev;
            for (int i = size - 1; i > index; i--)
                curr = curr.prev;
        }

        Node pred = curr.prev;
        Node succ = curr.next;

        pred.next = succ;
        succ.prev = pred;

        size--;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */