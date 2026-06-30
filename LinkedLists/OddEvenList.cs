public class Solution {
    public ListNode OddEvenList(ListNode head) {
        // 1. ADDED: Null check to prevent crashing on empty or single-node lists
        if (head == null || head.next == null) return head;

        int count = 0;
        ListNode prev = null;
        ListNode secondNode = head.next;
        ListNode curr = head;
        ListNode nextNode = curr.next;
        
        while (curr != null && nextNode != null && nextNode.next != null){
            ListNode temp = nextNode.next;
            curr.next = temp;
            prev = curr;
            curr = nextNode;
            nextNode = temp;
            count++;
        }
        
        // 2. CORRECTED: Depending on the count, we must attach the last odd node 
        // to 'secondNode' AND ensure the last even node points to null.
        if (count % 2 == 0) {
            // When count is even, 'curr' lands on the last odd node
            // and 'nextNode' lands on the last even node.
            nextNode.next = null;     // Cap off the even list
            curr.next = secondNode;   // Connect odd to even
        }
        else {
            // When count is odd, 'nextNode' lands on the last odd node
            // and 'curr' lands on the last even node.
            curr.next = null;         // Cap off the even list
            nextNode.next = secondNode; // Connect odd to even
        }
        
        return head;
    }
}