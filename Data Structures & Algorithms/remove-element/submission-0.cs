public class Solution {
    public int RemoveElement(int[] nums, int val) {
        List<int> result = new List<int>();

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != val) {
                result.Add(nums[i]);
            } else {
                continue;
            }
        }

        for (int i = 0; i < result.Count; i++) {
            nums[i] = result[i];
        }
        return result.Count;
    }
}