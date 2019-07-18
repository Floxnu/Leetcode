public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if (l1 == null && l2 == null) return null;
        if (l1 == null) return l2;
        if (l2 == null) return l1;

        
        ListNode currentHead = l1.val < l2.val ? l1 : l2;
        ListNode head = currentHead;
        ListNode currentL1 = currentHead == l1 ? l1.next : l1;
        ListNode currentL2 = currentHead == l2 ? l2.next : l2;
        while (currentHead != null)
        {
            if(currentL1 != null && currentL2 != null)
            {
                if(currentL1.val < currentL2.val)
                {
                    currentHead.next = currentL1;
                    currentL1 = currentL1.next;
                } else
                {
                    currentHead.next = currentL2;
                    currentL2 = currentL2.next;
                }
            }
            else if(currentL1 != null){
                currentHead.next = currentL1;
                currentL1 = currentL1.next;
            } else if(currentL2 != null){
                currentHead.next = currentL2;
                currentL2 = currentL2.next;
            }
            currentHead = currentHead.next;
        }
        return head;
    }
}