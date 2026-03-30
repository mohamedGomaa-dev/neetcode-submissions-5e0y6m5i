public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

        
        List<int> indexes = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];
            
            if (keyValuePairs.ContainsKey(difference))
            {
                indexes.Add(keyValuePairs[difference]);
                indexes.Add(i);
                indexes.Sort();
                return indexes.ToArray();
            }
            keyValuePairs[nums[i]] = i;
        }
        return indexes.ToArray();
    }
}
