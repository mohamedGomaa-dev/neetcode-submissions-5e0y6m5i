public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> result = new();
        Backtrack(result, [], nums, 0, target, 0);
        return result;
    }

    public void Backtrack(List<List<int>> result, List<int> path, int[] nums, int total, int target, int i) {
        if (total == target)
        {
            result.Add(new List<int>(path));
            return;
        }
        if (total > target || i >= nums.Length)
            return;
        
        path.Add(nums[i]);
        Backtrack(result, path, nums, total + nums[i], target, i);
        path.RemoveAt(path.Count - 1);
        Backtrack(result, path, nums, total, target, i + 1);
    }
}
