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
        int idx = 0;
        List<int> temp = new List<int>();
        ListNode ptr = head;
        while(head != null)
        {
            temp.Add(head.val) ;
            head = head.next;
            idx++;
        }
        while (ptr != null)
        {
            if(temp[idx-1] != ptr.val)
            {
                return false;
            }
            idx--;
            ptr = ptr.next;
        }
        return true;
    }
}