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
    public void GetTreeElements(TreeNode root, List<int> arr) {
        if (root == null) return;
        GetTreeElements(root.left, arr);
        GetTreeElements(root.right, arr);
        arr.Add(root.val);
    }
    public int KthSmallest(TreeNode root, int k) {
        
        List<int> arr = new List<int>();
        GetTreeElements(root, arr);
        if (arr.Count == 0) return -1;
        arr.Sort();
        return arr[k - 1];
        
    }
}
