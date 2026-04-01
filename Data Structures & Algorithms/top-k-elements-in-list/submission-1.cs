public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        // create a dictionary that stores the frequency of each element in the array
        // get the number of k maximum frequencies in the dictionary
        Dictionary<int, int> frequencies = new Dictionary<int, int>();
        foreach (int x in nums)
        {
            if (!frequencies.ContainsKey(x))
            {
                frequencies[x] = 0;
            }
            frequencies[x]++;
        }
        

        List<int> result = new List<int>();
        

        while (k >0)
        {
            foreach (var kvp in frequencies)
            {

                if (kvp.Value == frequencies.Max(kvp => kvp.Value))
                {
                    result.Add(kvp.Key);
                    frequencies.Remove(kvp.Key);

                    k--;
                }

                if (k <= 0)
                {
                    break;
                }

            }
        }
        return result.ToArray();
    }
}
