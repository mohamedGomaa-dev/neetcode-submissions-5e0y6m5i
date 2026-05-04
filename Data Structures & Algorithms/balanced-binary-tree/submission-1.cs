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
    private int TreeHeight(TreeNode root) {
    if (root == null) return 0;
    return 1 + Math.Max(TreeHeight(root.left), TreeHeight(root.right));
}
    public bool IsBalanced(TreeNode root) {
        if (root == null) return true;
        int left = TreeHeight(root.left);
        int right = TreeHeight(root.right);
        return (left == right || left == right -1 || left == right + 1) && IsBalanced(root.left) && IsBalanced(root.right);
    }
}
