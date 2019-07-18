/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
 public ListNode DeleteDuplicates(ListNode head)
    {
         HashSet<int> uniques = new HashSet<int>();
        ListNode currentHead = head;
        ListNode previousNode = null;
        ListNode currentNode = head;
        while (currentNode != null)
        {

            if (!uniques.Contains(currentNode.val))
            {
                uniques.Add(currentNode.val);
                if (currentNode.next != null && currentNode.val == currentNode.next.val)
                {
                    ListNode target = GetSkipDuplicateTargetNode(currentNode);
                    if (previousNode != null)
                    {
                        previousNode.next = target;
                        currentNode = null;
                    }
                    if(currentHead == currentNode)
                    {
                        currentHead = target;
                    }
                }
                else
                {
                    previousNode = currentNode;
                }
            }
            else
            {
                if(previousNode != null)
                {
                    previousNode.next = currentNode.next;
                }

            }

            if (currentNode != null)
            {
                currentNode = currentNode.next;
            }
            else
            {
                currentNode = previousNode;
            }


        }
        return currentHead;
    }
    public ListNode GetSkipDuplicateTargetNode(ListNode startNode) {
        ListNode targetNode = startNode;
        if(startNode.next == null)
        {
            return null;
        }
        if(startNode.val == startNode.next.val)
        {
            return GetSkipDuplicateTargetNode(startNode.next);
        }
        return startNode.next;
    }
}