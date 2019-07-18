/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
               HashSet<int> uniques = new HashSet<int>();
        ListNode previousNode = null;
        ListNode currentNode = head;
        while(currentNode != null)
        {

            if (!uniques.Contains(currentNode.val))
            {
                uniques.Add(currentNode.val);
                previousNode = currentNode;
            }
            else
            {
                previousNode.next = currentNode.next; 

            }
            currentNode = currentNode.next;

        }
        return head;
    }
}