public class Solution
{
    


public class MyLinkedList {
    
    class Node {
        int data ;
        Node next;
        
        Node(int val){
            this.data = val;
            this.next = null;
        }
    }
    
    Node head;
    int size;

    public MyLinkedList() {
        head = null;
        size = 0;
    }
    
    public int Get(int index) {
        if(index<0 || index >=size){
            return -1;
        }
        Node current = head;
        
        for (int i=0; i<index; i++){
            current=current.next;
        }
        return current.data;
    }
    
    public void AddAtHead(int val) {
        Node newNode = new Node(val);
        newNode.next = head;
        head = newNode;
        size++;
        
    }
    
    public void AddAtTail(int val) {
        Node newNode = new Node(val);
        if(head == null){
            head = newNode;
            size++;
            return;
        }
        Node current = head;
        while(current != null){
            current = current.next;
        }
        current.next = newNode;
        size++;
    }
    
    public void AddAtIndex(int index, int val) {
        if(index<0 || index>size){
            return;
        }
        if(index == 0){
            AddAtHead(val);
            return;
        }
         // Find previous node
        Node prev = head;

        for (int i = 0; i < index - 1; i++)
        {
            prev = prev.next;
        }

        Node newNode = new Node(val);

        newNode.next = prev.next;
        prev.next = newNode;

        size++;
    }

    
    public void DeleteAtIndex(int index) {
        if (index < 0 || index >= size)
            return;

        // Delete head
        if (index == 0)
        {
            head = head.next;
            size--;
            return;
        }

        // Find previous node
        Node prev = head;

        for (int i = 0; i < index - 1; i++)
        {
            prev = prev.next;
        }

        prev.next = prev.next.next;

        size--;
    }
    
}}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */