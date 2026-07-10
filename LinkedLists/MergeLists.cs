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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode mergedList = new ListNode(0, null);
        ListNode head = mergedList;
        ListNode ptr1 = list1;
        ListNode ptr2 = list2;
        
        while(ptr1 != null && ptr2 != null){
            if (ptr1.val <= ptr2.val){
                head.next = ptr1;
                ptr1 = ptr1.next;
            }
            else{
                head.next = ptr2;
                ptr2 = ptr2.next;
            }
            
            head = head.next;
           
        }
        if(ptr1 != null){
            head.next = ptr1;
        }
        else{
            head.next = ptr2;
            
        }
        return mergedList.next;
    }
}