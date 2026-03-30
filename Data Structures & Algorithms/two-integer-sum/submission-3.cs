public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
    
        Dictionary<int, int> indexes = new Dictionary<int, int>();
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];
            if (indexes.ContainsKey(difference))
            {
                result.Add(indexes[difference]);
                result.Add(i);
                result.Sort();
                return result.ToArray();
            } else
            {
                indexes.Add(nums[i], i);
            }
        }

        return result.ToArray();
return result.ToArray();
    }
}
