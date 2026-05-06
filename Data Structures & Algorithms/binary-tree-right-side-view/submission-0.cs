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
    public List<int> RightSideView(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        List<int> result = new List<int>();

        if (root != null) {
            queue.Enqueue(root);
        }
        while (queue.Count > 0) {
            int length = queue.Count;
            List<int> levelValues = new List<int>();
            for (int i = 0; i< length; i++) {
                TreeNode curr = queue.Dequeue();
                levelValues.Add(curr.val);
                if (curr.left != null) {
                    queue.Enqueue(curr.left);
                }
                if (curr.right != null) {
                    queue.Enqueue(curr.right);
                }
            }
            result.Add(levelValues[levelValues.Count -1]);
        }
        return result;
    }
}
