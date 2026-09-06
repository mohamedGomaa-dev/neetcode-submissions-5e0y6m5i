public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> result = new();
        if (nums.Length > 0)
            Backtrack(result,nums);
        
        return result;
    }
    private void Backtrack(List<List<int>> result, int[] nums, int start = 0, List<int>? path = null) {
        path ??= new();

        result.Add(new List<int>(path));
        for (int i = start; i < nums.Length; i++) {
            path.Add(nums[i]);
            Backtrack(result, nums, i + 1, path);
            path.RemoveAt(path.Count - 1);
        }
    }
}
