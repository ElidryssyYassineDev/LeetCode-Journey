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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode sumList = new ListNode(0, null);
        ListNode head = sumList;
        int remainder = 0;
        int carry = 0;
        int temp = 0;
        
        while (l1 != null && l2 != null){
            temp = l1.val + l2.val + carry;
            carry = temp / 10;
            remainder = temp % 10;
            
            if(temp < 10){
                ListNode tempList = new ListNode(temp, null);
                head.next = tempList;
                head = head.next;
            }else {
                ListNode tempList = new ListNode(remainder, null);
                head.next = tempList;
                head = head.next;
            }
            
            l1 = l1.next;
            l2 = l2.next;
        }
        while (l1 != null){
            temp = l1.val + carry;
            carry = temp / 10;
            remainder = temp % 10;
            head.next = new ListNode (remainder,null);
            head = head.next;
            l1 = l1.next;
        }
        while (l2 != null){
            temp = l2.val + carry;
            carry = temp / 10;
            remainder = temp % 10;
            head.next = new ListNode (remainder, null);
            head = head.next;
            l2 = l2.next;
        }
        
        if (carry > 0){
            head.next = new ListNode(carry);
        }
        
        
        return sumList.next;
    }
}