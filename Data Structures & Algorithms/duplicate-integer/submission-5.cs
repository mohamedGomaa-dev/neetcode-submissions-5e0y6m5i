public class Solution {
    public bool hasDuplicate(int[] nums) {
        // create a hashset to mark the unique values

        HashSet<int> set = new HashSet<int>();

        // loop through nums
        for (int i = 0; i < nums.Length; i++)
        {
            // if the set already contains the number it means it is a duplicate
            if (set.Contains(nums[i])) return true;
            set.Add(nums[i]); // add it to check for the next iteration
        }
        return false;
    }
}