/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public var val: Int
 *     public var next: ListNode?
 *     public init(_ val: Int) {
 *         self.val = val
 *         self.next = nil
 *     }
 * }
 */
class Solution {
    var newFirst: ListNode? = nil
    func reverseList(_ head: ListNode?) -> ListNode? {
        if(head?.next == nil){
            return head;
        }
        reverseNode(head, 0)
        return newFirst

    }

    func reverseNode(_ node: ListNode?, _ depth: Int){
        if(node?.next == nil && depth > 0){
            newFirst = node
        }
        if(node?.next != nil){
            reverseNode(node?.next, depth+1)
        }

        node?.next?.next = node
        if (depth == 0){
            node?.next = nil
        }
    }


}