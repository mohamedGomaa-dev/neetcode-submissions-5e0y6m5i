public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // create a map 
        // loop through the array
        // difference equals target minus current item
        // if map contains key of difference 
        // return difference value from map and current index
        // if not add current item to the map as a key and its index as a value
        // return empty array if the loop finishes
        List<int> result = new List<int>(); 
        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
        for (int i = 0; i <  nums.Length; i++)
        {
            int diff = target - nums[i];
            if (keyValuePairs.ContainsKey(diff))
            {
                result.Add(keyValuePairs[diff]);
                result.Add(i);
                result.Sort();
                return result.ToArray();
            } else
            {
                keyValuePairs[nums[i]] = i;
            }
        }
        return result.ToArray();

    }
}

