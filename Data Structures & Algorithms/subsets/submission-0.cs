public class Solution
{
    List<List<int>> results = [];

    public List<List<int>> Subsets(int[] nums)
    {
        Backtrack(nums);
        return results;
    }

    private void Backtrack(int[] nums, int start = 0, List<int>? path = null)
    {
        path ??= [];

        results.Add(new List<int>(path));
        for (int i = start; i < nums.Length; i++)
        {
            path.Add(nums[i]);
            Backtrack(nums, i + 1, path);
            path.RemoveAt(path.Count - 1);
        }
    }
}
