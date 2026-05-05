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
    private int counter = 1;
    private int smallestKvalue = -1;
    public int KthSmallest(TreeNode root, int k) {
        // I will keep a counter starting from one and increasing with traversal
        // if it reachest k that means we are in the right node
        // we return the value node
        if (root == null) return counter;

        KthSmallest(root.left, k);
        if (counter == k) {
            if (smallestKvalue == -1) {
                smallestKvalue = root.val;
            }
            return smallestKvalue;

        } else {
            counter++;
        }
        KthSmallest(root.right, k);
        return smallestKvalue;
        
    }
}
