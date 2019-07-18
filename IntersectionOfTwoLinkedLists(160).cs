/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        if (headA == null || headB == null) return null;
        HashSet<ListNode> uniqueNodes = new HashSet<ListNode>();
        ListNode currentNode = headA;
        while (currentNode != null)
        {
            uniqueNodes.Add(currentNode);
            currentNode = currentNode.next;
        }
        currentNode = headB;
        while (currentNode != null)
        {
            if (uniqueNodes.Add(currentNode))
            {
                currentNode = currentNode.next;
            }
            else
            {
                return currentNode;
            }
        }
        return null;
    }
}