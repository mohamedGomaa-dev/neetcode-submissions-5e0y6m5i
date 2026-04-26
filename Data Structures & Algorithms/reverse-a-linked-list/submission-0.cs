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
    public List<int> GetListValues(ListNode head) {
        List<int> result = new List<int>();
        ListNode curr = head;
        while (curr != null) {
            result.Add(curr.val);
            curr = curr.next;
        }
        result.Reverse();
        return result;
    }
    public ListNode ReverseList(ListNode head) {
        // brute force approach:
        // create a normal list
        // add values to it
        // loop through the linked list again
        // put the list items in reversed orders
        ListNode curr = head;
        if (curr != null) {
            List<int> listVals = GetListValues(head);
            int i = 0;
            while (curr != null) {
                curr.val = listVals[i++];
                curr = curr.next;
            }
        }
        return head;
    }
}
