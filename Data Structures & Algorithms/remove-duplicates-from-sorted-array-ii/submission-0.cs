public class Solution {
    public int RemoveDuplicates(int[] nums) {
        HashSet<int> set = [];
        var k = 0;
        var visitedOnce = false;
        for (int i = 0; i < nums.Length; i++) {
            if (set.Contains(nums[i])) 
                continue;
            
            if (visitedOnce && nums[i] == nums[i - 1]) {
                visitedOnce = false;
                set.Add(nums[i]);
                nums[k] = nums[i];
                k++;
            } else {
                visitedOnce = true;
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}