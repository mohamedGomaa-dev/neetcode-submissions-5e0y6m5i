public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        Dictionary<int, int> kvp = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if (kvp.ContainsKey(diff)) {
                result[0] = kvp[diff];
                result[1] = i;
                return result;
            }
            kvp[nums[i]] = i;
        }

        return result;
    }
}
