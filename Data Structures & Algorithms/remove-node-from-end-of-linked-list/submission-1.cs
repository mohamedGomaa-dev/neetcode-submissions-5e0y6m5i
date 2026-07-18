public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var fast = head;
        var slow = head;
        ListNode prev = null;
        for (int i = 0; i < n; i++)
            fast = fast?.next;

        while (fast != null)
        {
            fast = fast.next;
            prev = slow;
            slow = slow.next;
        }
        if (prev == null) {
            head = head.next;
            return head;
        }
        prev.next = slow.next;
        return head;
    }
}
