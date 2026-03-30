public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {

        // 1. loop through each number in array
        // 2. make sure that difference between target and number exists in the dictionary
        // 3. if exists return index of number and index of difference contained in dictionary
        // 4. add the number index to the dictionary in order to compare to next loops
        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];
            if (keyValuePairs.ContainsKey(difference))
            {
                result.Add(keyValuePairs[difference]);
                result.Add(i);
                result.Sort();
                return result.ToArray();
            }

            keyValuePairs[nums[i]] = i;
        }

        return result.ToArray();

    }
}
