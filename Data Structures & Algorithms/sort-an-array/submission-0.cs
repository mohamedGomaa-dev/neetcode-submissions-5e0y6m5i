public class Solution {
    public int[] SortArray(int[] nums) {
        for (int i = 1; i < nums.Length; i++) {
            int j = i - 1;
            while (j >= 0 && nums[j + 1] < nums[j]) {
                int temp = nums[j+1];
                nums[j+1] = nums[j];
                nums[j] = temp;
                j--;
            }
        }
        return nums;
    }
}