public class Solution {
    public int MaxArea(int[] heights) {
        int maxAmount = int.MinValue;
        int l = 0;
        int r = heights.Length - 1;
        while (l < r) {
            int height = Math.Min(heights[l], heights[r]);
            int width = r - l;
            int amount = height * width;
            maxAmount = Math.Max(maxAmount, amount);
            if (heights[l] > heights[r]) {
                r--;
            } else {
                l++;
            }
        }
        return maxAmount;
    }
}
