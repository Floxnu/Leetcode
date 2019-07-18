/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public var val: Int
 *     public var left: TreeNode?
 *     public var right: TreeNode?
 *     public init(_ val: Int) {
 *         self.val = val
 *         self.left = nil
 *         self.right = nil
 *     }
 * }
 */
class Solution {
    var minDepth = Int.max
    func minDepth(_ root: TreeNode?) -> Int {
        if(root == nil){
            return 0
        }
        if(root?.left == nil && root?.right == nil){
            return 1
        }
        if(root?.left != nil){
            TreeNodeDFS(root!.left!, 1)
        }
        if(root?.right != nil) {
            TreeNodeDFS(root!.right!, 1)
        }
        return minDepth
    }

    func TreeNodeDFS(_ currentNode: TreeNode, _ currentDepth: Int){
        if(currentNode.left == nil && currentNode.right == nil){
            if(currentDepth + 1 < minDepth){
                minDepth = currentDepth + 1
            }
            return
        }
        if(currentNode.left != nil){
            TreeNodeDFS(currentNode.left!, currentDepth+1)
        }
        if (currentNode.right != nil) {
            TreeNodeDFS(currentNode.right!, currentDepth+1)
        }
    }
}