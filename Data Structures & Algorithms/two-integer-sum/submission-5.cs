public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!keyValuePairs.ContainsKey(i))
            {
                keyValuePairs[nums[i]] = i;
            }
        }
        List<int> indexes = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];
            if (keyValuePairs.TryGetValue(difference, out int index))
            {
                if (index == i)
                {
                    continue;
                }
            }
            if (keyValuePairs.ContainsKey(difference))
            {
                indexes.Add(keyValuePairs[difference]);
                indexes.Add(i);
                indexes.Sort();
                return indexes.ToArray();
            }
        }
        return indexes.ToArray();
    }
}
