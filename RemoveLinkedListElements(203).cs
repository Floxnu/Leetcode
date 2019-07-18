/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
       if (head == null) return null;
        ListNode currentHead = head;
        ListNode previousNode = null;
        ListNode currentNode = head;
        while(currentNode != null)
        {
            if(currentNode.val == val)
            {
                if(previousNode != null)
                {
                    previousNode.next = currentNode.next;
                    currentNode = previousNode.next;
                } else
                {
                    currentHead = currentNode.next;
                    currentNode = currentHead;
                }
            }
            else
            {
                previousNode = currentNode;
                currentNode = currentNode.next;
            }
        }
        return currentHead;
    }
}