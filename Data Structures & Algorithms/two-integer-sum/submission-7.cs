public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
        List<int> result = new List<int>();
        for (int i =0; i <  nums.Length; i++)
        {
            int difference = target - nums[i];

            if (keyValuePairs.ContainsKey(difference))
            {
                result.Add(i);
                result.Add(keyValuePairs[difference]);
                result.Sort();
                return result.ToArray();
            }
                        keyValuePairs[nums[i]] = i;

        }

        return result.ToArray();

    }
}
