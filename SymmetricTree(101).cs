/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsSymmetric(TreeNode root) {
        if (root == null) return true;
        if(root.left == null && root.right == null) return true;
        if (root.left != null && root.right != null)
        {
            if (root.left.val != root.right.val) return false;
            Queue<TreeNode> treeBFSLeft = new Queue<TreeNode>();
            Queue<TreeNode> treeBFSRight = new Queue<TreeNode>();
            
            treeBFSLeft.Enqueue(root.left);
            treeBFSRight.Enqueue(root.right);
            
            while (treeBFSLeft.Count > 0 && treeBFSRight.Count > 0)
            {
                TreeNode currentLeftmost = treeBFSLeft.Dequeue();
                TreeNode currentRightmost = treeBFSRight.Dequeue();

                if (currentLeftmost.val != currentRightmost.val) return false;
                if ((currentLeftmost.left != null && currentRightmost.right == null) || (currentLeftmost.left == null && currentRightmost.right != null)) return false;
                if ((currentLeftmost.right != null && currentRightmost.left == null) || (currentLeftmost.right == null && currentRightmost.left != null)) return false;
                if (currentLeftmost.left != null & currentRightmost.right != null)
                {
                    treeBFSLeft.Enqueue(currentLeftmost.left);
                    treeBFSRight.Enqueue(currentRightmost.right);
                }
                if(currentLeftmost.right != null && currentRightmost.left != null)
                {
                    treeBFSLeft.Enqueue(currentLeftmost.right);
                    treeBFSRight.Enqueue(currentRightmost.left);
                }
            }
            return true;
        }
        return false; 
    }
}