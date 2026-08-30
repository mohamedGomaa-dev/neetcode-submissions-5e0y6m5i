public class Solution {
        List<List<int>> result = new List<List<int>>();

    public List<List<int>> SubsetsWithDup(int[] nums) {
        if (nums.Length > 0)
        {
            Array.Sort(nums);
            Backtrack(nums);

        }

        return result;
    }
    private void Backtrack(int[] arr, int start = 0, List<int>? path = null) {
        path ??= [];
            result.Add(new List<int>(path));

        for (int i = start; i < arr.Length; i++) {
            if (i > start && arr[i] == arr[i - 1])
                continue;
            path.Add(arr[i]);
            Backtrack(arr, i + 1, path);
            path.RemoveAt(path.Count - 1);
        }
    }
}
