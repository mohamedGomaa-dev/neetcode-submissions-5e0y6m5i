public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        // create a dictionary to map the frequencies
        // loop through the array
        // if the map contains the item return true
        // else put the item in the map
        // return false after the loop ends
        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int i in nums)
        {
            if (freq.ContainsKey(i))
            {
                return true;
            } else
            {
                freq[i] = 1;
            }
        }
        return false;
    }
}