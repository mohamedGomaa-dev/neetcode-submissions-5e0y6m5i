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
    public List<List<int>> LevelOrder(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        List<List<int>> result = new List<List<int>>();

        if (root != null) {
            queue.Enqueue(root);
        }
        while (queue.Count > 0) {
            List<int> level = new List<int>();
            int length = queue.Count;
            for (int i = 0; i < length; i++) {
                TreeNode curr = queue.Dequeue();
                level.Add(curr.val);
                if (curr.left != null) {
                    queue.Enqueue(curr.left);

                }
                if (curr.right != null) {
                    queue.Enqueue(curr.right);
                }
            }
            result.Add(level);
        }
        return result;
    }
}
