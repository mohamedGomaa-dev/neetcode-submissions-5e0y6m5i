public class Solution {
    public bool HasPathSum(TreeNode root, int targetSum) {
        // Base case: if the node is null, no path exists
        if (root == null) return false;

        // Check if it's a leaf node
        if (root.left == null && root.right == null) {
            return root.val == targetSum;
        }

        // Recursively check left and right subtrees with the updated target sum
        int remainingSum = targetSum - root.val;
        return HasPathSum(root.left, remainingSum) || HasPathSum(root.right, remainingSum);
    }
}