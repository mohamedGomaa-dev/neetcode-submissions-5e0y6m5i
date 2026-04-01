public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        // create a dictionary that stores the frequency of each element in the array
        // get the number of k maximum frequencies in the dictionary
        SortedDictionary<int, int> frequencies = new SortedDictionary<int, int>();
        foreach (int x in nums)
        {
            if (!frequencies.ContainsKey(x))
            {
                frequencies[x] = 0;
            }
            frequencies[x]++;
        }


        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        foreach (var kvp in frequencies)
        {
            pq.Enqueue(kvp.Key, kvp.Value);
        }
        int[] result = new int[k];
        for(int i =0; i < k; i++)
        {
            result[i] = pq.Dequeue();
        }

        return result;
    }
}
