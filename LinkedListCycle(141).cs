/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> visitedNodes = new HashSet<ListNode>();
        ListNode currentNode = head;
        while (currentNode != null)
        {
            if (visitedNodes.Add(currentNode))
            {
                currentNode = currentNode.next;
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}