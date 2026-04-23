public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // we will loop through nums
        // we create difference = target - nums[i]
        // we check if difference is in the dictionary
        // if yes return [i, differency] 
        // add nums[i] to dictionary with value i

        Dictionary<int, int> dict = new Dictionary<int, int>();
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];
            if (dict.ContainsKey(difference))
            {
                result[0] = dict[difference];
                result[1] = i;
                return result;
            }
            dict[nums[i]] = i;
        }

        return result;
    }
}
