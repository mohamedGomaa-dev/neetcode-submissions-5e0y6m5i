public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> result = new();

        Backtrack(result,[], nums);

        return result;
    }
    private void Backtrack(List<List<int>> result,List<int> path, int[] nums) {
        if (path.Count == nums.Length)
        {
            result.Add(new List<int>(path));
            return;
        }
        for (int i = 0; i < nums.Length; i++) {
            if (path.Contains(nums[i]))
                continue;
            
            path.Add(nums[i]);
            Backtrack(result, path, nums);
            path.RemoveAt(path.Count - 1);
        }
    }
}
