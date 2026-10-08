public class Solution {
    public int RemoveDuplicates(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        var p = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (set.Contains(nums[i])) 
                continue;
            set.Add(nums[i]);
            nums[p] = nums[i];
            p++;
        }
        return p;
    }
}