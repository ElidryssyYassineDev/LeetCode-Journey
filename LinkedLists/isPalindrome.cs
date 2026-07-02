/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        
        ListNode fast = head;
        ListNode slow = head;
        ListNode prev;
        ListNode temp;
        
        //Floyd's algorithms
        while (fast != null && fast.next != null){
            fast = fast.next.next;
            slow = slow.next;
        }
        
        //Reversal
        prev = slow;
        slow = slow.next;
        prev.next = null;
        while(slow != null){
            temp = slow.next;
            slow.next = prev;
            prev = slow;
            slow = temp;
        }
        
        //Comparaison
        fast = head;
        slow = prev;
        while(slow != null){
            if(slow.val != fast.val){
                return false;
            } 
            fast = fast.next;
            slow = slow.next;
        }
        return true;
    }
}