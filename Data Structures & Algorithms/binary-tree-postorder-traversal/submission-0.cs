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
    List<int> arr = new List<int>();
    public List<int> PostorderTraversal(TreeNode root) {
        if (root == null) return arr;
        PostorderTraversal(root.left);
        PostorderTraversal(root.right);
        arr.Add(root.val);
        return arr;   
    }
}