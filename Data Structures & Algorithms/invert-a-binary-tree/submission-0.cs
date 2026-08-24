/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if (root is null)
            return root;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0) {
            var current = queue.Dequeue();
            if (current.left is not null)
                queue.Enqueue(current.left);
            if (current.right is not null)
                queue.Enqueue(current.right);
            var left = current.left;
            current.left = current.right;
            current.right = left;
        }
        return root;
    }
}
