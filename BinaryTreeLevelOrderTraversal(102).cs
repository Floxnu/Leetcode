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
    
    public struct NodeWithLevel
    {
        public TreeNode node;
        public int nodeLevel;
        public NodeWithLevel(TreeNode node, int level)
        {
            this.node = node;
            this.nodeLevel = level;
        }
    }
    
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> result = new List<IList<int>>();
        if (root == null)
        {
            return result;
        }

        Queue<NodeWithLevel> dfsQueue = new Queue<NodeWithLevel>();

        dfsQueue.Enqueue(new NodeWithLevel(root, 0));

        while (dfsQueue.Count > 0)
        {
            List<int> currentLevel = new List<int>();
            NodeWithLevel currentNode = dfsQueue.Dequeue();
            if (currentNode.nodeLevel >= result.Count)
            {
                currentLevel.Add(currentNode.node.val);
                result.Add(currentLevel);
            } else
            {
                result[currentNode.nodeLevel].Add(currentNode.node.val);
            }

            if (currentNode.node.left != null)
            {
                NodeWithLevel newNode = new NodeWithLevel(currentNode.node.left, currentNode.nodeLevel + 1);
                dfsQueue.Enqueue(newNode);
            }
            if (currentNode.node.right != null)
            {
                NodeWithLevel newNode = new NodeWithLevel(currentNode.node.right, currentNode.nodeLevel + 1);
                dfsQueue.Enqueue(newNode);
            }
        }
        return result;
    }
}